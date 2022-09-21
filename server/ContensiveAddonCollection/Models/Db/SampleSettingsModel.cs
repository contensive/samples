
using System;
using Contensive.BaseClasses;
using Contensive.Models.Db;

namespace Contensive.Addons.AddonSamples {
    namespace Models.Db {
        /// <summary>
        /// This is a sample design block 'settings' table
        /// </summary>
        public class SampleSettingsModel : DesignBlockBaseModel {
            /// <summary>
            /// table definition
            /// </summary>
            public static  DbBaseTableMetadataModel tableMetadata { get; } = new DbBaseTableMetadataModel("Sample Setting Content", "dbSampleSettingTable", "default", false);
            //
            //====================================================================================================
            // sample model properties for a design block settings record.
            //
            // these properties exactly match fields in the site's content (and the resulting database table it creates)
            // these properties should be of the following types:
            //
            // -- The five basic Contensive types
            //public string sampleDbFieldText { get; set; }
            //public int sampleDbFieldInteger { get; set; }
            //public bool sampleDbFieldBoolean { get; set; }
            //public DateTime sampleDbFieldDate { get; set; }
            //public double sampleDbFieldNumber { get; set; }
            //
            // -- Sample nullable property Types. Use these nullable types if the Contensive field should read and save null instead of the default value for these types 
            // -- for example, if a field containing null represents a 'not set' condition, use a nullable model property to prevent the model from setting the value on save.
            //public int? sampleDbFieldNullableInteger { get; set; }
            //public bool? sampleDbFieldNullableBoolean { get; set; }
            //public DateTime? sampleDbFieldNullableDate { get; set; }
            //public double? sampleDbFieldNullableNumber { get; set; }
            //
            // -- Types matching Contensive fields that control files
            //public FieldTypeCSSFile sampleDbFieldCssFile { get; set; }
            //public FieldTypeHTMLFile sampleDbFielHtmlFile { get; set; }
            //public FieldTypeJavascriptFile sampleDbFieldJavascriptFile { get; set; }
            //public FieldTypeTextFile sampleDbFieldTextFile { get; set; }
            // 
            //
            public string imageFilename { get; set; }
            public string headline { get; set; }
            public string embed { get; set; }
            public string description { get; set; }
            public string buttonText { get; set; }
            public string buttonUrl { get; set; }
            public int imageAspectRatioId { get; set; }
            public string btnStyleSelector { get; set; }
            // ====================================================================================================
            public static SampleSettingsModel createOrAddSettings(CPBaseClass cp, string settingsGuid) {
                SampleSettingsModel result = create<SampleSettingsModel>(cp, settingsGuid);
                if ((result == null)) {
                    // 
                    // -- create default content
                    result = DesignBlockBaseModel.addDefault<SampleSettingsModel>(cp);
                    result.name = tableMetadata.contentName + " " + result.id;
                    result.ccguid = settingsGuid;
                    result.themeStyleId = 0;
                    result.padTop = false;
                    result.padBottom = false;
                    result.padRight = false;
                    result.padLeft = false;
                    // 
                    // -- create custom content
                    result.imageFilename = string.Empty;
                    result.imageAspectRatioId = 3;
                    result.headline = "Lorem Ipsum Dolor";
                    result.description = "<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>";
                    result.embed = string.Empty;
                    result.buttonUrl = string.Empty;
                    result.buttonText = string.Empty;
                    // 
                    result.save(cp);
                    // 
                    // -- track the last modified date
                    cp.Content.LatestContentModifiedDate.Track(result.modifiedDate);
                }
                return result;
            }
        }
    }
}
