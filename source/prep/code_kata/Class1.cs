using System;

namespace prep.code_kata
{
    public class UnixTimestampConverter
    {
        public DateTime ToDateTime(string timeStamp)
        {
            // Unix timestamp is seconds past epoch
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            var timeStampDouble = Double.Parse(timeStamp);
            dtDateTime = dtDateTime.AddSeconds(timeStampDouble).ToLocalTime();
            return dtDateTime;
        }
    }
}
