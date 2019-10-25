# Known Pose API

Get and set (accurate) semantic poses for an environment. See full documentation
on [SwaggerHub](https://app.swaggerhub.com/apis-docs/kw90/known-pose-api/1.1.0).

This repository holds the so far required client SDKs and server stubs.

## Generate Client SDKs or Server Stubs in a CI Chain

Additional SDKs or stubs can be generated using the OpenAPI Generator CLI docker
image from 
[kw90/openapi-generator-cli](https://cloud.docker.com/repository/docker/kw90/openapi-generator-cli/general).
The official image doesn't allow calling easily in a CI environment like Gitlab
CI. This image is to allow that.

To generate a new Python client SDK in a GitLab CI chain first generate the
artifacts and then deploy them to a repository. The `client-config` and
`repo-config` folders contain configuration files for the generated code. Each
additional language requires at least a `[LANGUAGE].json` client-config
configuration file that specifies the name and version of the package.

### Generate Artifacts

add this to the
`.gitlab-ci.yml`

```yaml
build-python-client:
  image: kw90/openapi-generator-cli
  stage: build-python-client
  script:
    - java -jar /openapi-generator-cli.jar generate
      -g python
      -i spec/swagger.json
      -c client-config/python.json
      -o gen/pypi/client
  artifacts:
    name: "${CI_JOB_NAME}_${CI_COMMIT_REF_NAME}"
    paths:
      - gen/pypi/client
```

or for C#

```yaml
build-csharp-client:
  image: kw90/openapi-generator-cli
  stage: build-csharp-client
  script:
    - java -jar /openapi-generator-cli.jar generate
      -g csharp
      -i spec/swagger.json
      -c client-config/csharp.json
      -o gen/csharp
  artifacts:
    name: "${CI_JOB_NAME}_${CI_COMMIT_REF_NAME}"
    paths:
      - gen/csharp
```

The generated code and corresponding documentation files are being saved in the
`/builds/[Group/Subgroup/ProjectName]/gen/` folder.

## Deploy Artifacts

Use the following stage to deploy the previously generated artifacts.

```yaml
deploy-python:
  image: python:3.7
  stage: deploy-python
  dependencies:
    - build-python-client
  script:
    - pip install twine
    - echo "[distutils]" >> ~/.pypirc
    - echo "index-servers =" >> ~/.pypirc
    - echo "    repohub" >> ~/.pypirc
    - echo "" >> ~/.pypirc
    - echo "[repohub]" >> ~/.pypirc
    - echo "repository=${PYPI_REPO}" >> ~/.pypirc
    - echo "username=${REGISTRY_USER}" >> ~/.pypirc
    - echo "password=${REGISTRY_PASSWORD}" >> ~/.pypirc
    - cp repo-config/python/setup.cfg gen/pypi/client/setup.cfg
    - cd gen/pypi/client
    - python3 setup.py check sdist bdist
    - python setup.py sdist bdist_wheel
    - twine upload -r repohub dist/*.tar.gz
    - cd ../..
    - 'which ssh-agent || ( apt-get update -y && apt-get install openssh-client git -y )'
    - eval $(ssh-agent -s)
    - echo "$SSH_PRIVKEY_RUNNER" | tr -d '\r' | ssh-add - > /dev/null
    - mkdir -p ~/.ssh
    - chmod 700 ~/.ssh
    - ssh-keyscan -t ed25519 gitlab.example.com >> ~/.ssh/known_hosts
    - chmod 644 ~/.ssh/known_hosts
    - git config --global user.email "gitlab@runner"
    - git config --global user.name "GitLab CI"
    - git clone git@gitlab.example.com:mt-kawa/api-clients/known-pose-clients.git
    - cd known-pose-clients
    - rm -r python || true
    - cp -r ../pypi/client python
    - git add .
    - git commit -m "Deploy new python client"
    - git push origin master
```

The script is quite long, as it packages and distributes the package for
`python` and `python3` to a private repository. It then pushes the generated
client to a separate repository over ssh. URLs, user names and passwords are
filled in using environment variables at runtime.


## Generate Client SDKs or Server Stubs by Hand

The same docker image can also be used to generate the clients / servers and
their documentation by hand. To do so start a container with your user ID and
group ID, such that the resulting files will be owned by you instead of the root
user. Also, pass in the current directory as a volume inside the container
located at `/local`.

```zsh
docker run -it --rm --name openapi-generator --user $(id -u):$(id -g) --volume `pwd`:/local kw90/openapi-generator-cli:latest sh
```

Once the shell inside the container is available run the following command to
generate the client or server code and documentation


```zsh
java -jar /openapi-generator-cli.jar generate -g python -i spec/swagger.json -c client-config/python.json -o python-client
```


