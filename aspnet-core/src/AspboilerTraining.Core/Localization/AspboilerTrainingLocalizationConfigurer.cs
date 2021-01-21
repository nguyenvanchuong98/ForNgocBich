using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace AspboilerTraining.Localization
{
    public static class AspboilerTrainingLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(AspboilerTrainingConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(AspboilerTrainingLocalizationConfigurer).GetAssembly(),
                        "AspboilerTraining.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
