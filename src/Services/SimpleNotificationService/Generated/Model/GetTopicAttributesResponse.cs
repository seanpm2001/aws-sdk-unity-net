/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the sns-2010-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// Response for GetTopicAttributes action.
    /// </summary>
    public partial class GetTopicAttributesResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A map of the topic's attributes. Attributes in this map include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DeliveryPolicy</code> – The JSON serialization of the topic's delivery policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DisplayName</code> – The human-readable name used in the <code>From</code>
        /// field for notifications to <code>email</code> and <code>email-json</code> endpoints.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Owner</code> – The AWS account ID of the topic's owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Policy</code> – The JSON serialization of the topic's access control policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SubscriptionsConfirmed</code> – The number of confirmed subscriptions for the
        /// topic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SubscriptionsDeleted</code> – The number of deleted subscriptions for the topic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SubscriptionsPending</code> – The number of subscriptions pending confirmation
        /// for the topic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TopicArn</code> – The topic's ARN.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EffectiveDeliveryPolicy</code> – Yhe JSON serialization of the effective delivery
        /// policy, taking system defaults into account.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following attribute applies only to <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-server-side-encryption.html">server-side-encryption</a>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>KmsMasterKeyId</code> - The ID of an AWS-managed customer master key (CMK)
        /// for Amazon SNS or a custom CMK. For more information, see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-server-side-encryption.html#sse-key-terms">Key
        /// Terms</a>. For more examples, see <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_DescribeKey.html#API_DescribeKey_RequestParameters">KeyId</a>
        /// in the <i>AWS Key Management Service API Reference</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

    }
}