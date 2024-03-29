﻿using MemoryPack;
using Stl.Fusion;
using System.Runtime.Serialization;

namespace Shared.Features
{

    [DataContract, MemoryPackable]
    public partial record CreateUserCommand(
        [property: DataMember] Session Session,
        [property: DataMember] UserView Entity) : ISessionCommand<bool>;

    [DataContract, MemoryPackable]
    public partial record UpdateUserCommand(
        [property: DataMember] Session Session,
        [property: DataMember] UserView Entity) : ISessionCommand<UserView>;

    [DataContract, MemoryPackable]
    public partial record DeleteUserCommand([property: DataMember] Session Session, [property: DataMember] long Id) : ISessionCommand<UserView>;
}
