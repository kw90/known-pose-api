# coding: utf-8

from __future__ import absolute_import

from flask import json
from six import BytesIO

from known_pose_service.models.accurate_pose_array import AccuratePoseArray  # noqa: E501
from known_pose_service.models.basic_pose import BasicPose  # noqa: E501
from known_pose_service.models.inaccurate_pose_array import InaccuratePoseArray  # noqa: E501
from known_pose_service.models.inline_response200 import InlineResponse200  # noqa: E501
from known_pose_service.test import BaseTestCase


class TestDevelopersController(BaseTestCase):
    """DevelopersController integration test stubs"""

    def test_add_accurate_pose(self):
        """Test case for add_accurate_pose

        adds an accurate pose item
        """
        body = BasicPose()
        response = self.client.open(
            '/kw90/known-pose-api/1.1.0/poses/accurate',
            method='POST',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_add_inaccurate_pose(self):
        """Test case for add_inaccurate_pose

        adds an inaccurate pose item
        """
        body = BasicPose()
        response = self.client.open(
            '/kw90/known-pose-api/1.1.0/poses',
            method='POST',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_poses_id_delete(self):
        """Test case for poses_id_delete

        deletes a pose item
        """
        response = self.client.open(
            '/kw90/known-pose-api/1.1.0/poses/{id}'.format(id='id_example'),
            method='DELETE')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_search_accurate_pose(self):
        """Test case for search_accurate_pose

        searches accurate pose
        """
        query_string = [('id', 'id_example'),
                        ('search_string', 'search_string_example'),
                        ('skip', 1),
                        ('limit', 50)]
        response = self.client.open(
            '/kw90/known-pose-api/1.1.0/poses/accurate',
            method='GET',
            query_string=query_string)
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_search_pose(self):
        """Test case for search_pose

        searches pose
        """
        query_string = [('id', 'id_example'),
                        ('search_string', 'search_string_example'),
                        ('skip', 1),
                        ('limit', 50)]
        response = self.client.open(
            '/kw90/known-pose-api/1.1.0/poses',
            method='GET',
            query_string=query_string)
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))


if __name__ == '__main__':
    import unittest
    unittest.main()
