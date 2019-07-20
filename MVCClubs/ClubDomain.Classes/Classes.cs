using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDomain.Classes
{
    class Classes
    {
        public class Club
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int ClubId { get; set; }
            public string ClubName { get; set; }
            [Column(TypeName = "date")]
            public DateTime CreationDate { get; set; }
            public int adminID { get; set; }
            public virtual ICollection<Member> clubMembers { get; set; }
            public virtual ICollection<ClubEvent> clubEvents { get; set; }


        }
        public class ClubEvent
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int EventID { get; set; }
            public string Venue { get; set; }
            public string Location { get; set; }
            [ForeignKey("associatedClub")]
            public int ClubId { get; set; }
            public virtual Club associatedClub { get; set; }
            public DateTime StartDateTime { get; set; }
            public DateTime EndDateTime { get; set; }
        }

        public class EventAttendnace
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int ID { get; set; }
            [ForeignKey("associatedEvent")]
            public int EventID { get; set; }
            [ForeignKey("memberAttending")]
            // Set Nullable to avoid cascading deletes 
            // which would lead to indirect circular deletes
            public int? AttendeeMember { get; set; }
            public virtual Member memberAttending { get; set; }
            public virtual ClubEvent associatedEvent { get; set; }
        }

        public class Member
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int MemberID { get; set; }
            public int AssociatedClub { get; set; }
            public string StudentID { get; set; }
            public bool approved { get; set; }
            [ForeignKey("AssociatedClub")]
            public virtual Club myClub { get; set; }
        }
    }

}

