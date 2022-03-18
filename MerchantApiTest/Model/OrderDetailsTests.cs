/* 
 * Merchant API
 *
 * Afterpay Merchant API Initial build
 *
 * OpenAPI spec version: 2017-03-01
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using MerchantApi.Api;
using MerchantApi.Model;
using MerchantApi.Client;
using System.Reflection;

namespace MerchantApi.Test
{
    /// <summary>
    ///  Class for testing OrderDetails
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class OrderDetailsTests
    {
        // TODO uncomment below to declare an instance variable for Refund
        //private Refund instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {

        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Refund
        /// </summary>
        [Test]
        public void OrderDetailsInstanceTests()
        {
            var phoneNumber = "0200000000";

            var amount = new Money("37.37", "NZD");
            var consumer = new Consumer(phoneNumber, "Given Name", "Surname", "youremail@yourwebsite.com");

            var billing = new Contact("Address Name", "AddressLine1", "AddressLine2", "Area 1", "Area 2", "Region", "9999", "CC", phoneNumber);
            var shipping = new Contact("Address Name", "AddressLine1", "AddressLine2", "Area 1", "Area 2", "Region", "9999", "CC", phoneNumber);

            var courier = new ShippingCourier("2021-01-01T12:00:00", "Courier Name", "Tracking Number", ShippingCourier.PriorityEnum.Standard.ToString());

            var amount1 = new Money("17.17", "NZD");
            var amount2 = new Money("20.20", "NZD");

            string[][] categories1 = { new string[] { "Sporting Goods1", "Climbing Equipment1", "Climbing1" }, new string[] { "Sale1", "Climbing1" } };
            string[][] categories2 = { new string[] { "Sporting Goods2", "Climbing Equipment2", "Climbing2" }, new string[] { "Sale2", "Climbing2" } };

            var item1 = new Item("Item1", "SKU1", 1, "https://www.selectsystems.com.au/afterpay-payment-plugin", "https://www.selectsystems.com.au/afterpay-payment-plugin.image.jpg", amount1, categories1);
            var item2 = new Item("Item2", "SKU2", 2, "https://www.selectsystems.com.au/afterpay-payment-plugin", "https://www.selectsystems.com.au/afterpay-payment-plugin.image.jpg", amount2, categories2);

            var items = new List<Item>();
            items.Add(item1);
            items.Add(item2);

            var discountAmount1 = new Money("1.00", "NZD");
            var discountAmount2 = new Money("2.00", "NZD");

            var discount1 = new Discount("Discount1", discountAmount1);
            var discount2 = new Discount("Discount1", discountAmount1);

            var discounts = new List<Discount>();
            discounts.Add(discount1);
            discounts.Add(discount2);

            string RedirectConfirmUrl = "https://orders.yourwebsite.com/confirm";
            string RedirectCancelUrl = "https://orders.yourwebsite.com/cancel";

            var merchant = new Merchant(RedirectConfirmUrl, RedirectCancelUrl);

            var merchantReference = "Reference1";

            var taxAmount = new Money("5.00", "NZD");
            var shippingAmount = new Money("7.00", "NZD");

            var instance = new OrderDetails(amount, consumer, billing, shipping, courier, items, discounts, merchant, merchantReference, taxAmount, shippingAmount);

            Assert.IsInstanceOf<OrderDetails> (instance, "variable 'instance' is a OrderDetails");
        }

    }

}
