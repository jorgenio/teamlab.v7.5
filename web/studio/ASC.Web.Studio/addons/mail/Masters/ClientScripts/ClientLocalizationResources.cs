/* 
 * 
 * (c) Copyright Ascensio System Limited 2010-2014
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Affero General Public License as
 * published by the Free Software Foundation, either version 3 of the
 * License, or (at your option) any later version.
 * 
 * http://www.gnu.org/licenses/agpl.html 
 * 
 */

using System.Collections.Generic;
using System.Web;
using ASC.Web.Mail.Resources;
using ASC.Web.Core.Client.HttpHandlers;

namespace ASC.Web.Mail.Masters.ClientScripts
{
    public class ClientLocalizationResources : ClientScriptLocalization
    {
        protected override string BaseNamespace
        {
            get { return "ASC.Mail.Resources"; }
        }

        protected override IEnumerable<KeyValuePair<string, object>> GetClientVariables(HttpContext context)
        {
            yield return RegisterResourceSet("MailResource", MailResource.ResourceManager);
            yield return RegisterResourceSet("MailScriptResource", MailScriptResource.ResourceManager);
            yield return RegisterResourceSet("MailAttachmentsResource", MailAttachmentsResource.ResourceManager);
            yield return RegisterResourceSet("MailActionCompleteResource", MailActionCompleteResource.ResourceManager);
        }
    }
}
