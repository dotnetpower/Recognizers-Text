﻿using Microsoft.Recognizers.Text.NumberWithUnit.English.Extractors;
using Microsoft.Recognizers.Text.Number.Utilities;
using System.Globalization;

namespace Microsoft.Recognizers.Text.NumberWithUnit.English.Parsers
{
    public class CurrencyParserConfiguration : EnglishNumberWithUnitParserConfiguration
    {
        public CurrencyParserConfiguration() : this(new CultureInfo(Culture.English)) { }

        public CurrencyParserConfiguration(CultureInfo ci) : base(ci)
        {
            this.BindDictionary(CurrencyExtractorConfiguration.CurrencySuffixList);
            this.BindDictionary(CurrencyExtractorConfiguration.CurrencyPrefixList);
        }
    }
}
