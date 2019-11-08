import connexion
import six

from known_pose_service.models.accurate_pose_array import AccuratePoseArray  # noqa: E501
from known_pose_service.models.basic_pose import BasicPose  # noqa: E501
from known_pose_service.models.inaccurate_pose_array import InaccuratePoseArray  # noqa: E501
from known_pose_service.models.inline_response200 import InlineResponse200  # noqa: E501
from known_pose_service import util


def add_accurate_pose(body=None):  # noqa: E501
    """adds an accurate pose item

    Adds an accurate pose to the system. Just give the Pose a name.  # noqa: E501

    :param body: Optional pose item to add
    :type body: dict | bytes

    :rtype: None
    """
    if connexion.request.is_json:
        body = BasicPose.from_dict(connexion.request.get_json())  # noqa: E501
    return 'do some magic!'


def add_inaccurate_pose(body=None):  # noqa: E501
    """adds an inaccurate pose item

    Adds an inaccurate pose to the system. Just give the Pose a name and optionally a Pose in the map to use.  # noqa: E501

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

    :rtype: AccuratePoseArray
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

    :rtype: InaccuratePoseArray
    """
    return 'do some magic!'
