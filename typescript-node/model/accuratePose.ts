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
 */

import { InaccuratePose } from './inaccuratePose';

/**
* A unique and stamped accurate Pose in free space.
*/
export class AccuratePose {
    'inaccuratePose': InaccuratePose;
    /**
    * Contents of the reference scan assembled as point cloud data following [RFC 4648 § 5](https://tools.ietf.org/html/rfc4648#section-5)
    */
    'referenceScan': string;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "inaccuratePose",
            "baseName": "inaccurate_pose",
            "type": "InaccuratePose"
        },
        {
            "name": "referenceScan",
            "baseName": "reference_scan",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return AccuratePose.attributeTypeMap;
    }
}
