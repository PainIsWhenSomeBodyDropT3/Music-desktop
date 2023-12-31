//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Music
{
    using System;
    using System.Collections.Generic;

    public partial class PlayList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PlayList()
        {
            this.PlayListSongs = new HashSet<PlayListSong>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }

        public virtual User Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlayListSong> PlayListSongs { get; set; }
        public PlayList(int id, string name, string description, int userId)
        {
            Id = id;
            Name = name;
            Description = description;
            UserId = userId;
        }

        public PlayList(string name, string description, int userId)
        {
            Name = name;
            Description = description;
            UserId = userId;
        }


        public override bool Equals(object obj)
        {
            var list = obj as PlayList;
            return list != null &&
                   Id == list.Id &&
                   Name == list.Name &&
                   Description == list.Description &&
                   UserId == list.UserId;
        }

        public override int GetHashCode()
        {
            var hashCode = 224666902;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Description);
            hashCode = hashCode * -1521134295 + UserId.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return "PlayList{" +
                 "Id=" + Id +
                 ", Name='" + Name + '\'' +
                 ", Description='" + Description + '\'' +
                 ", UserId=" + UserId +
                 '}';
        }
    }
}
