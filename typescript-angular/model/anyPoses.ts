/**
 * Known Pose API
 * Define and retrieve (accurate) semantic poses in a 2D environment.
 *
 * OpenAPI spec version: 1.2.0
 * Contact: Kai.Waelti@dfki.de
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */import { AnyOfAnyPosesItems } from './anyOfAnyPosesItems';


/**
 * Workaround Schema to allow sending different pose types in an array as a response. 
 */
export interface AnyPoses extends Array<AnyOfAnyPosesItems> { 
}