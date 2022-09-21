
using Contensive.Models.Db;

namespace Contensive.Addons.AddonSamples {
    namespace Models.Db {
        /// <summary>
        /// Design Block Themes is a table with just a name. These names are treated as html classes.
        /// Every design block settings record includes a field 'themeStyleId' which is a lookup into this table.
        /// if the user selects a record in this list, then when the design block is rendered a div wrapper will be added with this class.
        /// </summary>
        public class DesignBlockThemeModel : DbBaseModel {
            // 
            // ====================================================================================================
            /// <summary>
            /// metadata
            /// </summary>
            public static  DbBaseTableMetadataModel tableMetadata { get; } = new DbBaseTableMetadataModel("Design Block Themes", "dbthemes", "default", false);
            // 
            // ====================================================================================================
            // -- instance properties
        }
    }
}