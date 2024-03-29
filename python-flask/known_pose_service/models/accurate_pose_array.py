# coding: utf-8

from __future__ import absolute_import
from datetime import date, datetime  # noqa: F401

from typing import List, Dict  # noqa: F401

from known_pose_service.models.base_model_ import Model
from known_pose_service.models.accurate_pose import AccuratePose  # noqa: F401,E501
from known_pose_service import util


class AccuratePoseArray(Model):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    def __init__(self, pose_array: List[AccuratePose]=None):  # noqa: E501
        """AccuratePoseArray - a model defined in Swagger

        :param pose_array: The pose_array of this AccuratePoseArray.  # noqa: E501
        :type pose_array: List[AccuratePose]
        """
        self.swagger_types = {
            'pose_array': List[AccuratePose]
        }

        self.attribute_map = {
            'pose_array': 'pose_array'
        }
        self._pose_array = pose_array

    @classmethod
    def from_dict(cls, dikt) -> 'AccuratePoseArray':
        """Returns the dict as a model

        :param dikt: A dict.
        :type: dict
        :return: The AccuratePoseArray of this AccuratePoseArray.  # noqa: E501
        :rtype: AccuratePoseArray
        """
        return util.deserialize_model(dikt, cls)

    @property
    def pose_array(self) -> List[AccuratePose]:
        """Gets the pose_array of this AccuratePoseArray.


        :return: The pose_array of this AccuratePoseArray.
        :rtype: List[AccuratePose]
        """
        return self._pose_array

    @pose_array.setter
    def pose_array(self, pose_array: List[AccuratePose]):
        """Sets the pose_array of this AccuratePoseArray.


        :param pose_array: The pose_array of this AccuratePoseArray.
        :type pose_array: List[AccuratePose]
        """
        if pose_array is None:
            raise ValueError("Invalid value for `pose_array`, must not be `None`")  # noqa: E501

        self._pose_array = pose_array
