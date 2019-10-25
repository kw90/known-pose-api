# coding: utf-8

from __future__ import absolute_import

from flask import json
from six import BytesIO

from swagger_server.models.accurate_pose import AccuratePose  # noqa: E501
from swagger_server.models.all_poses import AllPoses  # noqa: E501
from swagger_server.models.basic_pose import BasicPose  # noqa: E501
from swagger_server.models.inaccurate_pose import InaccuratePose  # noqa: E501
from swagger_server.models.inline_response200 import InlineResponse200  # noqa: E501
from swagger_server.test import BaseTestCase


class TestDevelopersController(BaseTestCase):
    """DevelopersController integration test stubs"""

    def test_add_pose(self):
        """Test case for add_pose

        adds a pose item
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
        query_string = [('search_string', 'search_string_example'),
                        ('skip', 1),
                        ('limit', 50)]
        response = self.client.open(
            '/kw90/known-pose-api/1.1.0/poses/accurate',
            method='GET',
            query_string=query_string)
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_search_inaccurate_pose(self):
        """Test case for search_inaccurate_pose

        searches inaccurate pose
        """
        query_string = [('search_string', 'search_string_example'),
                        ('skip', 1),
                        ('limit', 50)]
        response = self.client.open(
            '/kw90/known-pose-api/1.1.0/poses/inaccurate',
            method='GET',
            query_string=query_string)
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_search_pose(self):
        """Test case for search_pose

        searches pose
        """
        query_string = [('search_string', 'search_string_example'),
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
