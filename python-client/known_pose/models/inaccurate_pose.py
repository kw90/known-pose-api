# coding: utf-8

"""
    Known Pose API

    Define and retrieve (accurate) semantic poses in a 2D environment.  # noqa: E501

    The version of the OpenAPI document: 1.1.0
    Contact: Kai.Waelti@dfki.de
    Generated by: https://openapi-generator.tech
"""


import pprint
import re  # noqa: F401

import six


class InaccuratePose(object):
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
        'orientation': 'Orientation',
        'id': 'str',
        'taken_at': 'datetime'
    }

    attribute_map = {
        'name': 'name',
        'position': 'position',
        'orientation': 'orientation',
        'id': 'id',
        'taken_at': 'taken_at'
    }

    def __init__(self, name=None, position=None, orientation=None, id=None, taken_at=None):  # noqa: E501
        """InaccuratePose - a model defined in OpenAPI"""  # noqa: E501

        self._name = None
        self._position = None
        self._orientation = None
        self._id = None
        self._taken_at = None
        self.discriminator = None

        self.name = name
        self.position = position
        self.orientation = orientation
        self.id = id
        self.taken_at = taken_at

    @property
    def name(self):
        """Gets the name of this InaccuratePose.  # noqa: E501


        :return: The name of this InaccuratePose.  # noqa: E501
        :rtype: str
        """
        return self._name

    @name.setter
    def name(self, name):
        """Sets the name of this InaccuratePose.


        :param name: The name of this InaccuratePose.  # noqa: E501
        :type: str
        """
        if name is None:
            raise ValueError("Invalid value for `name`, must not be `None`")  # noqa: E501

        self._name = name

    @property
    def position(self):
        """Gets the position of this InaccuratePose.  # noqa: E501


        :return: The position of this InaccuratePose.  # noqa: E501
        :rtype: Position
        """
        return self._position

    @position.setter
    def position(self, position):
        """Sets the position of this InaccuratePose.


        :param position: The position of this InaccuratePose.  # noqa: E501
        :type: Position
        """
        if position is None:
            raise ValueError("Invalid value for `position`, must not be `None`")  # noqa: E501

        self._position = position

    @property
    def orientation(self):
        """Gets the orientation of this InaccuratePose.  # noqa: E501


        :return: The orientation of this InaccuratePose.  # noqa: E501
        :rtype: Orientation
        """
        return self._orientation

    @orientation.setter
    def orientation(self, orientation):
        """Sets the orientation of this InaccuratePose.


        :param orientation: The orientation of this InaccuratePose.  # noqa: E501
        :type: Orientation
        """
        if orientation is None:
            raise ValueError("Invalid value for `orientation`, must not be `None`")  # noqa: E501

        self._orientation = orientation

    @property
    def id(self):
        """Gets the id of this InaccuratePose.  # noqa: E501


        :return: The id of this InaccuratePose.  # noqa: E501
        :rtype: str
        """
        return self._id

    @id.setter
    def id(self, id):
        """Sets the id of this InaccuratePose.


        :param id: The id of this InaccuratePose.  # noqa: E501
        :type: str
        """
        if id is None:
            raise ValueError("Invalid value for `id`, must not be `None`")  # noqa: E501

        self._id = id

    @property
    def taken_at(self):
        """Gets the taken_at of this InaccuratePose.  # noqa: E501


        :return: The taken_at of this InaccuratePose.  # noqa: E501
        :rtype: datetime
        """
        return self._taken_at

    @taken_at.setter
    def taken_at(self, taken_at):
        """Sets the taken_at of this InaccuratePose.


        :param taken_at: The taken_at of this InaccuratePose.  # noqa: E501
        :type: datetime
        """
        if taken_at is None:
            raise ValueError("Invalid value for `taken_at`, must not be `None`")  # noqa: E501

        self._taken_at = taken_at

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
        if not isinstance(other, InaccuratePose):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
