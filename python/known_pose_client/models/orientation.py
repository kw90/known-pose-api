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


class Orientation(object):
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
        'x': 'float',
        'y': 'float',
        'z': 'float',
        'w': 'float'
    }

    attribute_map = {
        'x': 'x',
        'y': 'y',
        'z': 'z',
        'w': 'w'
    }

    def __init__(self, x=None, y=None, z=None, w=None):  # noqa: E501
        """Orientation - a model defined in OpenAPI"""  # noqa: E501

        self._x = None
        self._y = None
        self._z = None
        self._w = None
        self.discriminator = None

        self.x = x
        self.y = y
        self.z = z
        self.w = w

    @property
    def x(self):
        """Gets the x of this Orientation.  # noqa: E501


        :return: The x of this Orientation.  # noqa: E501
        :rtype: float
        """
        return self._x

    @x.setter
    def x(self, x):
        """Sets the x of this Orientation.


        :param x: The x of this Orientation.  # noqa: E501
        :type: float
        """
        if x is None:
            raise ValueError("Invalid value for `x`, must not be `None`")  # noqa: E501

        self._x = x

    @property
    def y(self):
        """Gets the y of this Orientation.  # noqa: E501


        :return: The y of this Orientation.  # noqa: E501
        :rtype: float
        """
        return self._y

    @y.setter
    def y(self, y):
        """Sets the y of this Orientation.


        :param y: The y of this Orientation.  # noqa: E501
        :type: float
        """
        if y is None:
            raise ValueError("Invalid value for `y`, must not be `None`")  # noqa: E501

        self._y = y

    @property
    def z(self):
        """Gets the z of this Orientation.  # noqa: E501


        :return: The z of this Orientation.  # noqa: E501
        :rtype: float
        """
        return self._z

    @z.setter
    def z(self, z):
        """Sets the z of this Orientation.


        :param z: The z of this Orientation.  # noqa: E501
        :type: float
        """
        if z is None:
            raise ValueError("Invalid value for `z`, must not be `None`")  # noqa: E501

        self._z = z

    @property
    def w(self):
        """Gets the w of this Orientation.  # noqa: E501


        :return: The w of this Orientation.  # noqa: E501
        :rtype: float
        """
        return self._w

    @w.setter
    def w(self, w):
        """Sets the w of this Orientation.


        :param w: The w of this Orientation.  # noqa: E501
        :type: float
        """
        if w is None:
            raise ValueError("Invalid value for `w`, must not be `None`")  # noqa: E501

        self._w = w

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
        if not isinstance(other, Orientation):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
