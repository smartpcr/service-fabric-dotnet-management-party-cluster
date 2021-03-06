﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace PartyCluster.Common
{
    using System;

    public static class ExceptionExtension
    {
        /// <summary>
        /// For use when logging general exception messages:
        /// A number of APIs may return AggregateException with only one inner exception,
        /// where the Message property on the AggregateException isn't useful.
        /// This handy function picks out the actual message for logging.
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static string GetActualMessage(this Exception instance)
        {
            AggregateException ae = instance as AggregateException;

            if (ae != null && ae.InnerException != null)
            {
                return ae.InnerException.Message;
            }

            return instance.Message;
        }
    }
}