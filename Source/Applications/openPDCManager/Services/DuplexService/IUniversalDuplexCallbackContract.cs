﻿//******************************************************************************************************
//  IUniversalDuplexCallbackContract.cs - Gbtc
//
//  Copyright © 2010, Grid Protection Alliance.  All Rights Reserved.
//
//  Licensed to the Grid Protection Alliance (GPA) under one or more contributor license agreements. See
//  the NOTICE file distributed with this work for additional information regarding copyright ownership.
//  The GPA licenses this file to you under the Eclipse Public License -v 1.0 (the "License"); you may
//  not use this file except in compliance with the License. You may obtain a copy of the License at:
//
//      http://www.opensource.org/licenses/eclipse-1.0.php
//
//  Unless agreed to in writing, the subject software distributed under the License is distributed on an
//  "AS-IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. Refer to the
//  License for the specific language governing permissions and limitations.
//
//  Code Modification History:
//  ----------------------------------------------------------------------------------------------------
//  07/05/2009 - Mehulbhai Thakkar
//       Generated original version of source code.
//  09/15/2009 - Stephen C. Wills
//       Added new header and license agreement.
//
//******************************************************************************************************

using System;
using System.ServiceModel;

namespace openPDCManager.Services.DuplexService
{
    /// <summary>
    /// "Callback" part of Duplex contract: From the Service to Silverlight
    /// </summary>
    [ServiceContract]
    public interface IUniversalDuplexCallbackContract
    {
        [OperationContract(IsOneWay = true)]		
        void SendToClient(DuplexMessage msg);

        [OperationContract(IsOneWay = true, AsyncPattern = true)]
        IAsyncResult BeginSendToClient(DuplexMessage msg, AsyncCallback acb, object state);
        void EndSendToClient(IAsyncResult iar);
    }
}
