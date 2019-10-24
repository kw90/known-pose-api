import connexion
import six

from swagger_server.models.basic_pose import BasicPose  # noqa: E501
from swagger_server.models.object import Object  # noqa: E501
from swagger_server import util


def add_pose(body=None):  # noqa: E501
    """adds a pose item

    Adds an accurate or inaccurate pose to the system. Add current pose (without pose request body) to add an accurate pose.  # noqa: E501

    :param body: Optional pose item to add
    :type body: dict | bytes

    :rtype: None
    """
    if connexion.request.is_json:
        body = BasicPose.from_dict(connexion.request.get_json())  # noqa: E501
    return 'do some magic!'


def search_pose(search_string=None, skip=None, limit=None):  # noqa: E501
    """searches pose

    By passing in the appropriate options, you can search for defined semantic poses in the environment  # noqa: E501

    :param search_string: pass an optional search string for looking up a pose
    :type search_string: str
    :param skip: number of records to skip for pagination
    :type skip: int
    :param limit: maximum number of records to return
    :type limit: int

    :rtype: List[Object]
    """
    return 'do some magic!'
