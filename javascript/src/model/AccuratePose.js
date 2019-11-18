/**
 * Known Pose API
 * Define and retrieve (accurate) semantic poses in a 2D environment. This version is a workaround for some not yet available features of the OpenAPI Specification v3.0 (e.g. `anyOf` as a response type and adding a  `discriminator` for supporting polymorphism/composition). Therefore, ATM the sub-components BasicPose and InaccuratePose are reference objects inside their respective parent model.  
 *
 * The version of the OpenAPI document: 1.1.0
 * Contact: Kai.Waelti@dfki.de
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 *
 */

import ApiClient from '../ApiClient';
import InaccuratePose from './InaccuratePose';

/**
 * The AccuratePose model module.
 * @module model/AccuratePose
 * @version 1.1.10
 */
class AccuratePose {
    /**
     * Constructs a new <code>AccuratePose</code>.
     * A unique and stamped accurate Pose in free space.
     * @alias module:model/AccuratePose
     * @param inaccuratePose {module:model/InaccuratePose} 
     * @param referenceScan {String} Contents of the reference scan assembled as point cloud data following [RFC 4648 § 5](https://tools.ietf.org/html/rfc4648#section-5)
     */
    constructor(inaccuratePose, referenceScan) { 
        
        AccuratePose.initialize(this, inaccuratePose, referenceScan);
    }

    /**
     * Initializes the fields of this object.
     * This method is used by the constructors of any subclasses, in order to implement multiple inheritance (mix-ins).
     * Only for internal use.
     */
    static initialize(obj, inaccuratePose, referenceScan) { 
        obj['inaccurate_pose'] = inaccuratePose;
        obj['reference_scan'] = referenceScan;
    }

    /**
     * Constructs a <code>AccuratePose</code> from a plain JavaScript object, optionally creating a new instance.
     * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @param {module:model/AccuratePose} obj Optional instance to populate.
     * @return {module:model/AccuratePose} The populated <code>AccuratePose</code> instance.
     */
    static constructFromObject(data, obj) {
        if (data) {
            obj = obj || new AccuratePose();

            if (data.hasOwnProperty('inaccurate_pose')) {
                obj['inaccurate_pose'] = InaccuratePose.constructFromObject(data['inaccurate_pose']);
            }
            if (data.hasOwnProperty('reference_scan')) {
                obj['reference_scan'] = ApiClient.convertToType(data['reference_scan'], 'String');
            }
        }
        return obj;
    }


}

/**
 * @member {module:model/InaccuratePose} inaccurate_pose
 */
AccuratePose.prototype['inaccurate_pose'] = undefined;

/**
 * Contents of the reference scan assembled as point cloud data following [RFC 4648 § 5](https://tools.ietf.org/html/rfc4648#section-5)
 * @member {String} reference_scan
 */
AccuratePose.prototype['reference_scan'] = undefined;






export default AccuratePose;

