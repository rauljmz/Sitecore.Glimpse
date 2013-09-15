using System.Collections.Generic;

using Glimpse.Core.Tab.Assist;

namespace Sitecore.Glimpse.Analytics
{
    public class ProfilesSection
    {
        public static TabSection Create(RequestData requestData)
        {
            var profiles = (List<KeyValuePair<string, float>>) requestData[DataKey.Profiles];

            if ((profiles == null) || (profiles.Count == 0)) return null; 
            
            var section = new TabSection("Key", "Value");

            foreach (var profile in profiles)
            {
                section.AddRow().Column(profile.Key).Column(profile.Value);
            }

            return section;
        }
    }
}