import connexion
import six

from known_pose_service.models.accurate_pose import AccuratePose  # noqa: E501
from known_pose_service.models.basic_pose import BasicPose  # noqa: E501
from known_pose_service.models.inaccurate_pose import InaccuratePose  # noqa: E501
from known_pose_service.models.inline_response200 import InlineResponse200  # noqa: E501
from known_pose_service import util


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


def poses_id_delete(id):  # noqa: E501
    """deletes a pose item

    Deletes an accurate or inaccurate pose from the system using the &#x60;uuid&#x60;.  # noqa: E501

    :param id: uuid
    :type id: str

    :rtype: InlineResponse200
    """
    return 'do some magic!'


def search_accurate_pose(id=None, search_string=None, skip=None, limit=None):  # noqa: E501
    """searches accurate pose

    By passing in the appropriate options, you can search for defined accurate semantic poses in the environment  # noqa: E501

    :param id: optional uuid of a single accurate pose to be returned
    :type id: str
    :param search_string: pass an optional search string for looking up a pose
    :type search_string: str
    :param skip: number of records to skip for pagination
    :type skip: int
    :param limit: maximum number of records to return
    :type limit: int

    :rtype: List[AccuratePose]
    """
    return 'do some magic!'


def search_pose(id=None, search_string=None, skip=None, limit=None):  # noqa: E501
    """searches pose

    By passing in the appropriate options, you can search for defined semantic poses in the environment  # noqa: E501

    :param id: optional uuid of a single pose to be returned
    :type id: str
    :param search_string: pass an optional search string for looking up a pose
    :type search_string: str
    :param skip: number of records to skip for pagination
    :type skip: int
    :param limit: maximum number of records to return
    :type limit: int

    :rtype: List[InaccuratePose]
    """
    return 'do some magic!'
