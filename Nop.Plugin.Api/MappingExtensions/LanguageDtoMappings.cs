﻿// // -----------------------------------------------------------------------
// // <copyright from="2020" to="2020" file="LanguageDtoMappings.cs" company="Lindell Management">
// //    Copyright (c) Lindell Management All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using Nop.Core.Domain.Localization;
using Nop.Plugin.Api.AutoMapper;
using Nop.Plugin.Api.DTO.Languages;

namespace Nop.Plugin.Api.MappingExtensions
{
    public static class LanguageDtoMappings
    {
        public static LanguageDto ToDto(this Language language)
        {
            return language.MapTo<Language, LanguageDto>();
        }
    }
}
