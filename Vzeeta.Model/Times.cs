using System.ComponentModel.DataAnnotations;

namespace Vzeeta.Model
{
    public class Times
    {
        [Timestamp]
        public byte[] time { get; set; }
    }
}