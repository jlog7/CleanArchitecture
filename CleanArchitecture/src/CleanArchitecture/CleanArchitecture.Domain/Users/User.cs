using CleanArchitecture.Domain.Abstractions;
using CleanArchitecture.Domain.users;
using CleanArchitecture.Domain.Users.Events;

namespace CleanArchitecture.Domain.Users;

public sealed class User : Entity
{
    public Nombre? Nombre { get; private set; }
    public Apellido? Apellido { get; private set; }
    public Email? Email { get; private set; }

    private User(Guid id, Nombre nombre, Apellido apellido, Email email) : base(id)
    {
        this.Nombre = Nombre;
        this.Apellido = Apellido;
        this.Email = email;
    }

    public static User Create(Nombre nombre, Apellido apellido, Email email)
    {
        var user = new User(Guid.NewGuid(), nombre, apellido, email);
        user.RaiseDomainEvent(new UserCreatedDomainEvent(user.Id));
        return user;
    }
}