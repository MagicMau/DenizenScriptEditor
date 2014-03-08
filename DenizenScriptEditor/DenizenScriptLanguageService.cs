using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Package;
using Microsoft.VisualStudio.TextManager.Interop;
using Microsoft.VisualStudio.OLE.Interop;

namespace Deloitte.DenizenScriptEditor
{
    class DenizenScriptLanguageService : LanguageService
    {
        private LanguagePreferences _preferences;
        private Scanner _scanner;

        public override string GetFormatFilterList()
        {
            return "Denizen Script File (*.dscript)\n*.dscript";
        }

        public override LanguagePreferences GetLanguagePreferences()
        {
            if (_preferences == null)
            {
                _preferences = new LanguagePreferences(this.Site, typeof(DenizenScriptLanguageService).GUID, this.Name);
                _preferences.Init();
            }
            return _preferences;
        }

        public override IScanner GetScanner(IVsTextLines buffer)
        {
            if (_scanner == null)
            {
                _scanner = new Scanner(buffer);
            }
            return _scanner;
        }

        public override string Name
        {
            get { return "DenizenScript"; }
        }

        public override AuthoringScope ParseSource(ParseRequest req)
        {
            return new DenizenScriptAuthoringScope();
        }
    }
}
