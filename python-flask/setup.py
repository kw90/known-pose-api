# coding: utf-8

import sys
from setuptools import setup, find_packages

NAME = "known_pose_service"
VERSION = "1.1.6"
# To install the library, run the following
#
# python setup.py install
#
# prerequisite: setuptools
# http://pypi.python.org/pypi/setuptools

REQUIRES = ["connexion"]

setup(
    name=NAME,
    version=VERSION,
    description="Known Pose API",
    author_email="Kai.Waelti@dfki.de",
    url="",
    keywords=["Swagger", "Known Pose API"],
    install_requires=REQUIRES,
    packages=find_packages(),
    package_data={'': ['swagger/swagger.yaml']},
    include_package_data=True,
    entry_points={
        'console_scripts': ['known_pose_service=known_pose_service.__main__:main']},
    long_description="""\
    Define and retrieve (accurate) semantic poses in a 2D environment. This version is a workaround for some not yet available features of the OpenAPI Specification v3.0 (e.g. &#x60;anyOf&#x60; as a response type and adding a  &#x60;discriminator&#x60; for supporting polymorphism/composition). Therefore, ATM the sub-components BasicPose and InaccuratePose are reference objects inside their respective parent model.  
    """
)
