
using Contensive.Models.Db;

namespace Contensive.Addons.AddonSamples {
    namespace Models.Db {
        /// <summary>
        /// Design blocks are dropped on pages. When dropped, the system creates a Guid for this instance of the Design Block. 
        /// When rendered, the design block code uses that guid to create a 'settings' record in a table of its chosing.
        /// This model includes the common fields all design blocks must support and should be inherited by the model for this design block's settings table
        /// </summary>
        public class DesignBlockBaseModel : DbBaseModel {
            // 
            // ====================================================================================================
            // -- instance properties
            public string backgroundImageFilename { get; set; }
            public int fontStyleId { get; set; }
            public int themeStyleId { get; set; }
            public bool padTop { get; set; }
            public bool padBottom { get; set; }
            public bool padRight { get; set; }
            public bool padLeft { get; set; }
            public string styleheight { get; set; }
            public bool asFullBleed { get; set; }
        }
    }
}