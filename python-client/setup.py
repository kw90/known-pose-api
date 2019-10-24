# coding: utf-8

"""
    Known Pose API

    Define and retrieve (accurate) semantic poses in a 2D environment.  # noqa: E501

    The version of the OpenAPI document: 1.1.0
    Contact: Kai.Waelti@dfki.de
    Generated by: https://openapi-generator.tech
"""


from setuptools import setup, find_packages  # noqa: H301

NAME = "known-pose"
VERSION = "1.1.0"
# To install the library, run the following
#
# python setup.py install
#
# prerequisite: setuptools
# http://pypi.python.org/pypi/setuptools

REQUIRES = ["urllib3 >= 1.15", "six >= 1.10", "certifi", "python-dateutil"]

setup(
    name=NAME,
    version=VERSION,
    description="Known Pose API",
    author_email="Kai.Waelti@dfki.de",
    url="",
    keywords=["OpenAPI", "OpenAPI-Generator", "Known Pose API"],
    install_requires=REQUIRES,
    packages=find_packages(),
    include_package_data=True,
    long_description="""\
    Define and retrieve (accurate) semantic poses in a 2D environment.  # noqa: E501
    """
)
