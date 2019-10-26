# coding: utf-8

# flake8: noqa

"""
    Known Pose API

    Define and retrieve (accurate) semantic poses in a 2D environment. This version is a workaround for some not yet available features of the OpenAPI Specification v3.0 (e.g. `anyOf` as a response type and adding a  `discriminator` for supporting polymorphism/composition). Therefore, ATM the sub-components BasicPose and InaccuratePose are reference objects inside their respective parent model.    # noqa: E501

    The version of the OpenAPI document: 1.1.0
    Contact: Kai.Waelti@dfki.de
    Generated by: https://openapi-generator.tech
"""


from __future__ import absolute_import

__version__ = "1.1.6"

# import apis into sdk package
from known_pose_client.api.developers_api import DevelopersApi

# import ApiClient
from known_pose_client.api_client import ApiClient
from known_pose_client.configuration import Configuration
from known_pose_client.exceptions import OpenApiException
from known_pose_client.exceptions import ApiTypeError
from known_pose_client.exceptions import ApiValueError
from known_pose_client.exceptions import ApiKeyError
from known_pose_client.exceptions import ApiException
# import models into sdk package
from known_pose_client.models.accurate_pose import AccuratePose
from known_pose_client.models.basic_pose import BasicPose
from known_pose_client.models.inaccurate_pose import InaccuratePose
from known_pose_client.models.inline_response200 import InlineResponse200
from known_pose_client.models.orientation import Orientation
from known_pose_client.models.position import Position
