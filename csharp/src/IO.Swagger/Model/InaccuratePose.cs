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
    /// A unique and stamped inaccurate Pose in free space.
    /// </summary>
    [DataContract]
        public partial class InaccuratePose :  IEquatable<InaccuratePose>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InaccuratePose" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="dns">Unique name used to generate the uuid. (required).</param>
        /// <param name="basicPose">basicPose (required).</param>
        /// <param name="isAccurate">isAccurate (required).</param>
        /// <param name="takenAt">takenAt (required).</param>
        public InaccuratePose(Guid? id = default(Guid?), string dns = default(string), BasicPose basicPose = default(BasicPose), bool? isAccurate = default(bool?), DateTime? takenAt = default(DateTime?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for InaccuratePose and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "dns" is required (not null)
            if (dns == null)
            {
                throw new InvalidDataException("dns is a required property for InaccuratePose and cannot be null");
            }
            else
            {
                this.Dns = dns;
            }
            // to ensure "basicPose" is required (not null)
            if (basicPose == null)
            {
                throw new InvalidDataException("basicPose is a required property for InaccuratePose and cannot be null");
            }
            else
            {
                this.BasicPose = basicPose;
            }
            // to ensure "isAccurate" is required (not null)
            if (isAccurate == null)
            {
                throw new InvalidDataException("isAccurate is a required property for InaccuratePose and cannot be null");
            }
            else
            {
                this.IsAccurate = isAccurate;
            }
            // to ensure "takenAt" is required (not null)
            if (takenAt == null)
            {
                throw new InvalidDataException("takenAt is a required property for InaccuratePose and cannot be null");
            }
            else
            {
                this.TakenAt = takenAt;
            }
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Unique name used to generate the uuid.
        /// </summary>
        /// <value>Unique name used to generate the uuid.</value>
        [DataMember(Name="dns", EmitDefaultValue=false)]
        public string Dns { get; set; }

        /// <summary>
        /// Gets or Sets BasicPose
        /// </summary>
        [DataMember(Name="basic_pose", EmitDefaultValue=false)]
        public BasicPose BasicPose { get; set; }

        /// <summary>
        /// Gets or Sets IsAccurate
        /// </summary>
        [DataMember(Name="is_accurate", EmitDefaultValue=false)]
        public bool? IsAccurate { get; set; }

        /// <summary>
        /// Gets or Sets TakenAt
        /// </summary>
        [DataMember(Name="taken_at", EmitDefaultValue=false)]
        public DateTime? TakenAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InaccuratePose {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Dns: ").Append(Dns).Append("\n");
            sb.Append("  BasicPose: ").Append(BasicPose).Append("\n");
            sb.Append("  IsAccurate: ").Append(IsAccurate).Append("\n");
            sb.Append("  TakenAt: ").Append(TakenAt).Append("\n");
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
            return this.Equals(input as InaccuratePose);
        }

        /// <summary>
        /// Returns true if InaccuratePose instances are equal
        /// </summary>
        /// <param name="input">Instance of InaccuratePose to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InaccuratePose input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Dns == input.Dns ||
                    (this.Dns != null &&
                    this.Dns.Equals(input.Dns))
                ) && 
                (
                    this.BasicPose == input.BasicPose ||
                    (this.BasicPose != null &&
                    this.BasicPose.Equals(input.BasicPose))
                ) && 
                (
                    this.IsAccurate == input.IsAccurate ||
                    (this.IsAccurate != null &&
                    this.IsAccurate.Equals(input.IsAccurate))
                ) && 
                (
                    this.TakenAt == input.TakenAt ||
                    (this.TakenAt != null &&
                    this.TakenAt.Equals(input.TakenAt))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Dns != null)
                    hashCode = hashCode * 59 + this.Dns.GetHashCode();
                if (this.BasicPose != null)
                    hashCode = hashCode * 59 + this.BasicPose.GetHashCode();
                if (this.IsAccurate != null)
                    hashCode = hashCode * 59 + this.IsAccurate.GetHashCode();
                if (this.TakenAt != null)
                    hashCode = hashCode * 59 + this.TakenAt.GetHashCode();
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
