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
import BasicPose from './BasicPose';

/**
 * The InaccuratePose model module.
 * @module model/InaccuratePose
 * @version 1.1.10
 */
class InaccuratePose {
    /**
     * Constructs a new <code>InaccuratePose</code>.
     * A unique and stamped inaccurate Pose in free space.
     * @alias module:model/InaccuratePose
     * @param id {String} 
     * @param dns {String} Unique name used to generate the uuid.
     * @param basicPose {module:model/BasicPose} 
     * @param isAccurate {Boolean} 
     * @param takenAt {Date} 
     */
    constructor(id, dns, basicPose, isAccurate, takenAt) { 
        
        InaccuratePose.initialize(this, id, dns, basicPose, isAccurate, takenAt);
    }

    /**
     * Initializes the fields of this object.
     * This method is used by the constructors of any subclasses, in order to implement multiple inheritance (mix-ins).
     * Only for internal use.
     */
    static initialize(obj, id, dns, basicPose, isAccurate, takenAt) { 
        obj['id'] = id;
        obj['dns'] = dns;
        obj['basic_pose'] = basicPose;
        obj['is_accurate'] = isAccurate;
        obj['taken_at'] = takenAt;
    }

    /**
     * Constructs a <code>InaccuratePose</code> from a plain JavaScript object, optionally creating a new instance.
     * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @param {module:model/InaccuratePose} obj Optional instance to populate.
     * @return {module:model/InaccuratePose} The populated <code>InaccuratePose</code> instance.
     */
    static constructFromObject(data, obj) {
        if (data) {
            obj = obj || new InaccuratePose();

            if (data.hasOwnProperty('id')) {
                obj['id'] = ApiClient.convertToType(data['id'], 'String');
            }
            if (data.hasOwnProperty('dns')) {
                obj['dns'] = ApiClient.convertToType(data['dns'], 'String');
            }
            if (data.hasOwnProperty('basic_pose')) {
                obj['basic_pose'] = BasicPose.constructFromObject(data['basic_pose']);
            }
            if (data.hasOwnProperty('is_accurate')) {
                obj['is_accurate'] = ApiClient.convertToType(data['is_accurate'], 'Boolean');
            }
            if (data.hasOwnProperty('taken_at')) {
                obj['taken_at'] = ApiClient.convertToType(data['taken_at'], 'Date');
            }
        }
        return obj;
    }


}

/**
 * @member {String} id
 */
InaccuratePose.prototype['id'] = undefined;

/**
 * Unique name used to generate the uuid.
 * @member {String} dns
 */
InaccuratePose.prototype['dns'] = undefined;

/**
 * @member {module:model/BasicPose} basic_pose
 */
InaccuratePose.prototype['basic_pose'] = undefined;

/**
 * @member {Boolean} is_accurate
 */
InaccuratePose.prototype['is_accurate'] = undefined;

/**
 * @member {Date} taken_at
 */
InaccuratePose.prototype['taken_at'] = undefined;






export default InaccuratePose;

