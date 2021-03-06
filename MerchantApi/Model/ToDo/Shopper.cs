/* 
 * Merchant API
 *
 * Afterpay Merchant API Initial build
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
    /// The shopper details
    /// </summary>
    [DataContract]
    public partial class Shopper :  IEquatable<Shopper>, IValidatableObject
    {
        /// <summary>
        /// The shopper's gender
        /// </summary>
        /// <value>The shopper's gender</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GenderEnum
        {
            
            /// <summary>
            /// Enum Male for "Male"
            /// </summary>
            [EnumMember(Value = "Male")]
            Male,
            
            /// <summary>
            /// Enum Female for "Female"
            /// </summary>
            [EnumMember(Value = "Female")]
            Female,
            
            /// <summary>
            /// Enum Other for "Other"
            /// </summary>
            [EnumMember(Value = "Other")]
            Other
        }

        /// <summary>
        /// The shopper's gender
        /// </summary>
        /// <value>The shopper's gender</value>
        [DataMember(Name="gender", EmitDefaultValue=false)]
        public GenderEnum? Gender { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Shopper" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Shopper() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Shopper" /> class.
        /// </summary>
        /// <param name="Title">The shopper&#39;s title.</param>
        /// <param name="FirstName">The shopper&#39;s first name (required).</param>
        /// <param name="LastName">The shopper&#39;s last name (required).</param>
        /// <param name="MiddleName">The shopper&#39;s middle name.</param>
        /// <param name="Phone">The shopper&#39;s contact phone number.</param>
        /// <param name="Email">The shopper&#39;s email address (required).</param>
        /// <param name="BirthDate">The shopper&#39;s birth date in the form yyyy-mm-dd.</param>
        /// <param name="Gender">The shopper&#39;s gender.</param>
        /// <param name="Statistics">Statistics.</param>
        /// <param name="BillingAddress">BillingAddress (required).</param>
        public Shopper(string Title = default(string), string FirstName = default(string), string LastName = default(string), string MiddleName = default(string), string Phone = default(string), string Email = default(string), DateTime? BirthDate = default(DateTime?), GenderEnum? Gender = default(GenderEnum?), ShopperStatistics Statistics = default(ShopperStatistics), Contact BillingAddress = default(Contact))
        {
            // to ensure "FirstName" is required (not null)
            if (FirstName == null)
            {
                throw new InvalidDataException("FirstName is a required property for Shopper and cannot be null");
            }
            else
            {
                this.FirstName = FirstName;
            }
            // to ensure "LastName" is required (not null)
            if (LastName == null)
            {
                throw new InvalidDataException("LastName is a required property for Shopper and cannot be null");
            }
            else
            {
                this.LastName = LastName;
            }
            // to ensure "Email" is required (not null)
            if (Email == null)
            {
                throw new InvalidDataException("Email is a required property for Shopper and cannot be null");
            }
            else
            {
                this.Email = Email;
            }
            // to ensure "BillingAddress" is required (not null)
            if (BillingAddress == null)
            {
                throw new InvalidDataException("BillingAddress is a required property for Shopper and cannot be null");
            }
            else
            {
                this.BillingAddress = BillingAddress;
            }
            this.Title = Title;
            this.MiddleName = MiddleName;
            this.Phone = Phone;
            this.BirthDate = BirthDate;
            this.Gender = Gender;
            this.Statistics = Statistics;
        }
        
        /// <summary>
        /// The shopper&#39;s title
        /// </summary>
        /// <value>The shopper&#39;s title</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
        /// <summary>
        /// The shopper&#39;s first name
        /// </summary>
        /// <value>The shopper&#39;s first name</value>
        [DataMember(Name="first_name", EmitDefaultValue=false)]
        public string FirstName { get; set; }
        /// <summary>
        /// The shopper&#39;s last name
        /// </summary>
        /// <value>The shopper&#39;s last name</value>
        [DataMember(Name="last_name", EmitDefaultValue=false)]
        public string LastName { get; set; }
        /// <summary>
        /// The shopper&#39;s middle name
        /// </summary>
        /// <value>The shopper&#39;s middle name</value>
        [DataMember(Name="middle_name", EmitDefaultValue=false)]
        public string MiddleName { get; set; }
        /// <summary>
        /// The shopper&#39;s contact phone number
        /// </summary>
        /// <value>The shopper&#39;s contact phone number</value>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }
        /// <summary>
        /// The shopper&#39;s email address
        /// </summary>
        /// <value>The shopper&#39;s email address</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// The shopper&#39;s birth date in the form yyyy-mm-dd
        /// </summary>
        /// <value>The shopper&#39;s birth date in the form yyyy-mm-dd</value>
        [DataMember(Name="birth_date", EmitDefaultValue=false)]
        public DateTime? BirthDate { get; set; }
        /// <summary>
        /// Gets or Sets Statistics
        /// </summary>
        [DataMember(Name="statistics", EmitDefaultValue=false)]
        public ShopperStatistics Statistics { get; set; }
        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name="billing_address", EmitDefaultValue=false)]
        public Contact BillingAddress { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Shopper {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  Statistics: ").Append(Statistics).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
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
            return this.Equals(obj as Shopper);
        }

        /// <summary>
        /// Returns true if Shopper instances are equal
        /// </summary>
        /// <param name="other">Instance of Shopper to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Shopper other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.MiddleName == other.MiddleName ||
                    this.MiddleName != null &&
                    this.MiddleName.Equals(other.MiddleName)
                ) && 
                (
                    this.Phone == other.Phone ||
                    this.Phone != null &&
                    this.Phone.Equals(other.Phone)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.BirthDate == other.BirthDate ||
                    this.BirthDate != null &&
                    this.BirthDate.Equals(other.BirthDate)
                ) && 
                (
                    this.Gender == other.Gender ||
                    this.Gender != null &&
                    this.Gender.Equals(other.Gender)
                ) && 
                (
                    this.Statistics == other.Statistics ||
                    this.Statistics != null &&
                    this.Statistics.Equals(other.Statistics)
                ) && 
                (
                    this.BillingAddress == other.BillingAddress ||
                    this.BillingAddress != null &&
                    this.BillingAddress.Equals(other.BillingAddress)
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
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.MiddleName != null)
                    hash = hash * 59 + this.MiddleName.GetHashCode();
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.BirthDate != null)
                    hash = hash * 59 + this.BirthDate.GetHashCode();
                if (this.Gender != null)
                    hash = hash * 59 + this.Gender.GetHashCode();
                if (this.Statistics != null)
                    hash = hash * 59 + this.Statistics.GetHashCode();
                if (this.BillingAddress != null)
                    hash = hash * 59 + this.BillingAddress.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // Phone (string) pattern
            Regex regexPhone = new Regex(@"^\\+?[\\d\\s]+$", RegexOptions.CultureInvariant);
            if (false == regexPhone.Match(this.Phone).Success)
            {
                yield return new ValidationResult("Invalid value for Phone, must match a pattern of /^\\+?[\\d\\s]+$/.", new [] { "Phone" });
            }

            yield break;
        }
    }

}
