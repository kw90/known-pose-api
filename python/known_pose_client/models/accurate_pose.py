# coding: utf-8

"""
    Known Pose API

    Define and retrieve (accurate) semantic poses in a 2D environment. This version is a workaround for some not yet available features of the OpenAPI Specification v3.0 (e.g. `anyOf` as a response type and adding a  `discriminator` for supporting polymorphism/composition). Therefore, ATM the sub-components BasicPose and InaccuratePose are reference objects inside their respective parent model.    # noqa: E501

    The version of the OpenAPI document: 1.1.0
    Contact: Kai.Waelti@dfki.de
    Generated by: https://openapi-generator.tech
"""


import pprint
import re  # noqa: F401

import six


class AccuratePose(object):
    """NOTE: This class is auto generated by OpenAPI Generator.
    Ref: https://openapi-generator.tech

    Do not edit the class manually.
    """

    """
    Attributes:
      openapi_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    openapi_types = {
        'inaccurate_pose': 'InaccuratePose',
        'reference_scan': 'str'
    }

    attribute_map = {
        'inaccurate_pose': 'inaccurate_pose',
        'reference_scan': 'reference_scan'
    }

    def __init__(self, inaccurate_pose=None, reference_scan=None):  # noqa: E501
        """AccuratePose - a model defined in OpenAPI"""  # noqa: E501

        self._inaccurate_pose = None
        self._reference_scan = None
        self.discriminator = None

        self.inaccurate_pose = inaccurate_pose
        self.reference_scan = reference_scan

    @property
    def inaccurate_pose(self):
        """Gets the inaccurate_pose of this AccuratePose.  # noqa: E501


        :return: The inaccurate_pose of this AccuratePose.  # noqa: E501
        :rtype: InaccuratePose
        """
        return self._inaccurate_pose

    @inaccurate_pose.setter
    def inaccurate_pose(self, inaccurate_pose):
        """Sets the inaccurate_pose of this AccuratePose.


        :param inaccurate_pose: The inaccurate_pose of this AccuratePose.  # noqa: E501
        :type: InaccuratePose
        """
        if inaccurate_pose is None:
            raise ValueError("Invalid value for `inaccurate_pose`, must not be `None`")  # noqa: E501

        self._inaccurate_pose = inaccurate_pose

    @property
    def reference_scan(self):
        """Gets the reference_scan of this AccuratePose.  # noqa: E501

        Contents of the reference scan assembled as point cloud data following [RFC 4648 § 5](https://tools.ietf.org/html/rfc4648#section-5)  # noqa: E501

        :return: The reference_scan of this AccuratePose.  # noqa: E501
        :rtype: str
        """
        return self._reference_scan

    @reference_scan.setter
    def reference_scan(self, reference_scan):
        """Sets the reference_scan of this AccuratePose.

        Contents of the reference scan assembled as point cloud data following [RFC 4648 § 5](https://tools.ietf.org/html/rfc4648#section-5)  # noqa: E501

        :param reference_scan: The reference_scan of this AccuratePose.  # noqa: E501
        :type: str
        """
        if reference_scan is None:
            raise ValueError("Invalid value for `reference_scan`, must not be `None`")  # noqa: E501

        self._reference_scan = reference_scan

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.openapi_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, AccuratePose):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other