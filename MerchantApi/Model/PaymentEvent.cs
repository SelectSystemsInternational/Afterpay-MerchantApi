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
    /// The Payment Event object
    /// </summary>
    [DataContract]
    public partial class PaymentEvent :  IEquatable<PaymentEvent>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PaymentTypeEnum
        {

            /// <summary>
            /// Enum Authorised for "Auth Approved"
            /// </summary>
            [EnumMember(Value = "AUTH_APPROVED")]
            AUTH_APPROVED,

            /// <summary>
            /// Enum Captured for "Auth declined"
            /// </summary>
            [EnumMember(Value = "AUTH_DECLINED")]
            AUTH_DECLINED,

            /// <summary>
            /// Enum Captured for "Captured"
            /// </summary>
            [EnumMember(Value = "CAPTURED")]
            PARTIALLY_CAPTURED,

            /// <summary>
            /// Enum Captured for "Capture declined"
            /// </summary>
            [EnumMember(Value = "CAPTURE_DECLINED")]
            CAPTURE_DECLINED,

            /// <summary>
            /// Enum Captured for "Voided"
            /// </summary>
            [EnumMember(Value = "VOIDED")]
            VOIDED,

            /// <summary>
            /// Enum Captured for "Expired"
            /// </summary>
            [EnumMember(Value = "EXPIRED")]
            EXPIRED
        }

        /// <summary>
        /// Gets or Sets An order status of "APPROVED" or "DECLINED".
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public PaymentTypeEnum? Type { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Refund" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Refund" /> class.
        /// </summary>
        /// <param name="Id">The unique, Afterpay-generated event ID.</param>
        /// <param name="Created">A UTC timestamp of the event creation time, in ISO 8601 format.</param>
        /// <param name="Expires">A UTC timestamp of the event expire time, in ISO 8601 format.</param>
        /// <param name="Type">The event type.</param>
        /// <param name="Amount">The amount associated with the event.</param>
        /// <param name="PaymentEventMerchantReference">A unique reference for an individual payment capture event. If provided on Capture Payment, the value will appear in the daily settlement file as "Payment Event ID".</param>
        public PaymentEvent(string Id = default(string), string Created = default(string), string Expires = default(string), PaymentTypeEnum Type = default(PaymentTypeEnum),
            Money Amount = default(Money), string PaymentEventMerchantReference = default(string))
        {
            this.Id = Id;
            this.Created = Created;
            this.Expires = Expires;           
            this.Amount = Amount;
            this.PaymentEventMerchantReference = PaymentEventMerchantReference;
        }

        /// <summary>
        /// A unique request ID, required (in conjunction with merchantReference) for safe retries
        /// </summary>
        [DataMember(Name= "id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// The merchant's corresponding refund ID or reference,
        /// </summary>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public string Created { get; set; }
        /// <summary>
        /// The UTC timestamp of the event creation time
        /// </summary>
        [DataMember(Name = "expires", EmitDefaultValue = false)]
        public string Expires { get; set; }
        /// <summary>
        /// The amount associated with the event
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public Money Amount { get; set; }
        /// <summary>
        /// The unique reference for the individual refund event.
        /// </summary>
        /// <value>The date the refund was created</value>
        [DataMember(Name = "paymentEventMerchantReference", EmitDefaultValue = false)]
        public string PaymentEventMerchantReference { get; set; }

        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentEvent {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Expires: ").Append(Expires).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  PaymentEventMerchantReference: ").Append(PaymentEventMerchantReference).Append("\n");
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
            return this.Equals(obj as PaymentEvent);
        }

        /// <summary>
        /// Returns true if Refund instances are equal
        /// </summary>
        /// <param name="other">Instance of Refund to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentEvent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.Expires == other.Expires ||
                    this.Expires != null &&
                    this.Expires.Equals(other.Expires)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                ) &&
                (
                    this.PaymentEventMerchantReference == other.PaymentEventMerchantReference ||
                    this.PaymentEventMerchantReference != null &&
                    this.PaymentEventMerchantReference.Equals(other.PaymentEventMerchantReference)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Expires != null)
                    hash = hash * 59 + this.Expires.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                if (this.PaymentEventMerchantReference != null)
                    hash = hash * 59 + this.PaymentEventMerchantReference.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
