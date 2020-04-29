/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Lp.V20200224
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Lp.V20200224.Models;

   public class LpClient : AbstractClient{

       private const string endpoint = "lp.tencentcloudapi.com";
       private const string version = "2020-02-24";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public LpClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public LpClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 登录保护服务（LoginProtection，LP）针对网站和 APP 的用户登录场景，实时检测是否存在盗号、撞库等恶意登录行为，帮助开发者发现异常登录，降低恶意用户登录给业务带来的风险。
        /// </summary>
        /// <param name="req"><see cref="QueryLoginProtectionRequest"/></param>
        /// <returns><see cref="QueryLoginProtectionResponse"/></returns>
        public async Task<QueryLoginProtectionResponse> QueryLoginProtection(QueryLoginProtectionRequest req)
        {
             JsonResponseModel<QueryLoginProtectionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryLoginProtection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryLoginProtectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 登录保护服务（LoginProtection，LP）针对网站和 APP 的用户登录场景，实时检测是否存在盗号、撞库等恶意登录行为，帮助开发者发现异常登录，降低恶意用户登录给业务带来的风险。
        /// </summary>
        /// <param name="req"><see cref="QueryLoginProtectionRequest"/></param>
        /// <returns><see cref="QueryLoginProtectionResponse"/></returns>
        public QueryLoginProtectionResponse QueryLoginProtectionSync(QueryLoginProtectionRequest req)
        {
             JsonResponseModel<QueryLoginProtectionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryLoginProtection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryLoginProtectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
