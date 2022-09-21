
using System;

namespace Contensive.Addons.AddonSamples {
    namespace Models.Domain {
        // 
        // ====================================================================================================
        /// <summary>
        /// Domain models create objects used internally, not read from the Db (db models), or interact with the UI (view models)
        /// </summary>
        public class BlankDomainModel {
            // 
            // ====================================================================================================
            //
            public string sampleDbFieldText { get; set; }
            public int sampleDbFieldInteger { get; set; }
            public bool sampleDbFieldBoolean { get; set; }
            public DateTime sampleDbFieldDate { get; set; }
            public double sampleDbFieldNumber { get; set; }
            //
            // -- sample model nullable properties. These properties will save null if not initialized.
            //
            public int? sampleDbFieldNullableInteger { get; set; }
            public bool? sampleDbFieldNullableBoolean { get; set; }
            public DateTime? sampleDbFieldNullableDate { get; set; }
            public double? sampleDbFieldNullableNumber { get; set; }
        }
    }
}
