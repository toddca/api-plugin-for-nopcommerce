// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="ApiList.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;

namespace Nop.Plugin.Api.DataStructures
{
    public class ApiList<T> : List<T>
    {
        public ApiList(IQueryable<T> source, int pageIndex, int pageSize)
        {
            PageSize = pageSize;
            PageIndex = pageIndex;
            AddRange(source.Skip(pageIndex * pageSize).Take(pageSize).ToList());
        }

        public int PageIndex { get; }
        public int PageSize { get; }
    }
}
