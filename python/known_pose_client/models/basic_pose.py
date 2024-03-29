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


class BasicPose(object):
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
        'name': 'str',
        'position': 'Position',
        'orientation': 'Orientation'
    }

    attribute_map = {
        'name': 'name',
        'position': 'position',
        'orientation': 'orientation'
    }

    def __init__(self, name=None, position=None, orientation=None):  # noqa: E501
        """BasicPose - a model defined in OpenAPI"""  # noqa: E501

        self._name = None
        self._position = None
        self._orientation = None
        self.discriminator = None

        self.name = name
        self.position = position
        self.orientation = orientation

    @property
    def name(self):
        """Gets the name of this BasicPose.  # noqa: E501


        :return: The name of this BasicPose.  # noqa: E501
        :rtype: str
        """
        return self._name

    @name.setter
    def name(self, name):
        """Sets the name of this BasicPose.


        :param name: The name of this BasicPose.  # noqa: E501
        :type: str
        """
        if name is None:
            raise ValueError("Invalid value for `name`, must not be `None`")  # noqa: E501

        self._name = name

    @property
    def position(self):
        """Gets the position of this BasicPose.  # noqa: E501


        :return: The position of this BasicPose.  # noqa: E501
        :rtype: Position
        """
        return self._position

    @position.setter
    def position(self, position):
        """Sets the position of this BasicPose.


        :param position: The position of this BasicPose.  # noqa: E501
        :type: Position
        """
        if position is None:
            raise ValueError("Invalid value for `position`, must not be `None`")  # noqa: E501

        self._position = position

    @property
    def orientation(self):
        """Gets the orientation of this BasicPose.  # noqa: E501


        :return: The orientation of this BasicPose.  # noqa: E501
        :rtype: Orientation
        """
        return self._orientation

    @orientation.setter
    def orientation(self, orientation):
        """Sets the orientation of this BasicPose.


        :param orientation: The orientation of this BasicPose.  # noqa: E501
        :type: Orientation
        """
        if orientation is None:
            raise ValueError("Invalid value for `orientation`, must not be `None`")  # noqa: E501

        self._orientation = orientation

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
        if not isinstance(other, BasicPose):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
