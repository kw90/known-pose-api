/* 
 * Known Pose API
 *
 * Define and retrieve (accurate) semantic poses in a 2D environment. This version is a workaround for some not yet available features of the OpenAPI Specification v3.0 (e.g. `anyOf` as a response type and adding a  `discriminator` for supporting polymorphism/composition). Therefore, ATM the sub-components BasicPose and InaccuratePose are reference objects inside their respective parent model.  
 *
 * OpenAPI spec version: 1.1.0
 * Contact: Kai.Waelti@dfki.de
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Array containing matching poses
    /// </summary>
    [DataContract]
        public partial class InaccuratePoseArray :  IEquatable<InaccuratePoseArray>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InaccuratePoseArray" /> class.
        /// </summary>
        /// <param name="poseArray">poseArray (required).</param>
        public InaccuratePoseArray(List<InaccuratePose> poseArray = default(List<InaccuratePose>))
        {
            // to ensure "poseArray" is required (not null)
            if (poseArray == null)
            {
                throw new InvalidDataException("poseArray is a required property for InaccuratePoseArray and cannot be null");
            }
            else
            {
                this.PoseArray = poseArray;
            }
        }
        
        /// <summary>
        /// Gets or Sets PoseArray
        /// </summary>
        [DataMember(Name="pose_array", EmitDefaultValue=false)]
        public List<InaccuratePose> PoseArray { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InaccuratePoseArray {\n");
            sb.Append("  PoseArray: ").Append(PoseArray).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as InaccuratePoseArray);
        }

        /// <summary>
        /// Returns true if InaccuratePoseArray instances are equal
        /// </summary>
        /// <param name="input">Instance of InaccuratePoseArray to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InaccuratePoseArray input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PoseArray == input.PoseArray ||
                    this.PoseArray != null &&
                    input.PoseArray != null &&
                    this.PoseArray.SequenceEqual(input.PoseArray)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.PoseArray != null)
                    hashCode = hashCode * 59 + this.PoseArray.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
