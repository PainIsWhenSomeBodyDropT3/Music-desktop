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
    using Music.dto;
    using System;
    using System.Collections.Generic;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Comments = new HashSet<Comment>();
            this.PlayLists = new HashSet<PlayList>();
            this.UserMessages = new HashSet<UserMessage>();
        }

        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlayList> PlayLists { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserMessage> UserMessages { get; set; }
        public User(int id, string login, string password, Role role)
        {
            Id = id;
            Login = login;
            Password = password;
            Role = (int)role;
        }

        public User(string login, string password, Role role)
        {
            Login = login;
            Password = password;
            Role = (int)role;
        }

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }


        public override bool Equals(object obj)
        {
            var user = obj as User;
            return user != null &&
                   Id == user.Id &&
                   Login == user.Login &&
                   Password == user.Password &&
                   Role == user.Role;
        }

        public override int GetHashCode()
        {
            var hashCode = -480597469;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Login);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Password);
            hashCode = hashCode * -1521134295 + Role.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return "User{" +
                "Id=" + Id +
                ", Login='" + Login + '\'' +
                ", Password='" + Password + '\'' +
                ", Role=" + Role +
                '}';
        }
    }
}
