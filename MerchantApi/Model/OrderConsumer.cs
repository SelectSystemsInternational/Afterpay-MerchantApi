/* 
 * Merchant API
 *
 * ZipMoney Merchant API Initial build
 *
 * OpenAPI spec version: 2017-03-01
 * 
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

namespace MerchantApi.Model
{
    /// <summary>
    /// OrderConsumer
    /// </summary>
    [DataContract]
    public partial class OrderConsumer :  IEquatable<OrderConsumer>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderConsumer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderConsumer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderConsumer" /> class.
        /// </summary>
        /// <param name="Number">PhoneNumber</param>
        /// <param name="GivenNames">first names (required).</param>
        /// <param name="Surname">Surname (required).</param>
        /// <param name="Email">OrderConsumer&#39;s email (required).</param>
        public OrderConsumer(string PhoneNumber = default(string), string GivenNames = default(string), string Surname = default(string), string Email = default(string))
        {
            // to ensure "PhoneNumber" is required (not null)
            if (PhoneNumber == null)
            {
                throw new InvalidDataException("PhoneNumber is a required property for OrderConsumer and cannot be null");
            }
            else
            {
                this.PhoneNumber = PhoneNumber;
            }
            // to ensure "GivenNames" is required (not null)
            if (GivenNames == null)
            {
                throw new InvalidDataException("GivenNames is a required property for OrderConsumer and cannot be null");
            }
            else
            {
                this.GivenNames = GivenNames;
            }
            // to ensure "LastName" is required (not null)
            if (Surname == null)
            {
                throw new InvalidDataException("Surname is a required property for OrderConsumer and cannot be null");
            }
            else
            {
                this.Surname = Surname;
            }
            // to ensure "Email" is required (not null)
            if (Email == null)
            {
                throw new InvalidDataException("Email is a required property for OrderConsumer and cannot be null");
            }
            else
            {
                this.Email = Email;
            }
        }

        /// <summary>
        /// Phone Number
        /// </summary>
        /// <value>PhoneNumber</value>
        [DataMember(Name= "phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Given Names
        /// </summary>
        /// <value>Given Names</value>
        [DataMember(Name= "givenNames", EmitDefaultValue=false)]
        public string GivenNames { get; set; }
        /// <summary>
        /// Surname
        /// </summary>
        /// <value>Surname</value>
        [DataMember(Name= "surname", EmitDefaultValue=false)]
        public string Surname { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        /// <value>Email</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderConsumer {\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  GivenNames: ").Append(GivenNames).Append("\n");
            sb.Append("  Surname: ").Append(Surname).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as OrderConsumer);
        }

        /// <summary>
        /// Returns true if OrderConsumer instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderConsumer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderConsumer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) && 
                (
                    this.GivenNames == other.GivenNames ||
                    this.GivenNames != null &&
                    this.GivenNames.Equals(other.GivenNames)
                ) && 
                (
                    this.Surname == other.Surname ||
                    this.Surname != null &&
                    this.Surname.Equals(other.Surname)
                ) &&
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                if (this.GivenNames != null)
                    hash = hash * 59 + this.GivenNames.GetHashCode();
                if (this.Surname != null)
                    hash = hash * 59 + this.Surname.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
