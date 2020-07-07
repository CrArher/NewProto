using System.Collections.Generic;

namespace NewProto
{
    public abstract class Room
    {
        
        List<Mob> Mobs;
        public byte TypeID;
        public List<Door> Doors;
        public byte XCords;
        public byte YCords;
        
    }
}