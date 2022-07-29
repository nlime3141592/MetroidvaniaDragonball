using System;
using UnityEngine;

namespace JlMetroidvaniaProject
{
    public class GameKey<T_GameKeyEnum>
    where T_GameKeyEnum : System.Enum
    {
        private KeyCode[] m_tables;

        public GameKey()
        {
            int count = Enum.GetValues(typeof(T_GameKeyEnum)).Length;
            m_tables = new KeyCode[count];
        }

        public void Bind(T_GameKeyEnum gameKey, KeyCode keyCode)
        {
            int index = Convert.ToInt32(gameKey);
            m_tables[index] = keyCode;
        }

        public void Unbind(T_GameKeyEnum gameKey)
        {
            int index = CheckBind(gameKey);
            m_tables[index] = KeyCode.None;
        }

        public bool IsDown(T_GameKeyEnum gameKey)
        {
            int index = CheckBind(gameKey);
            return Input.GetKeyDown(m_tables[index]);
        }

        public bool IsPressed(T_GameKeyEnum gameKey)
        {
            int index = CheckBind(gameKey);
            return Input.GetKey(m_tables[index]);
        }

        public bool IsUp(T_GameKeyEnum gameKey)
        {
            int index = CheckBind(gameKey);
            return Input.GetKeyUp(m_tables[index]);
        }

        private int CheckBind(T_GameKeyEnum gameKey)
        {
            int index = Convert.ToInt32(gameKey);

            if(m_tables[index] == KeyCode.None)
                throw new Exception("Key Not Binded.");

            return index;
        }
    }
}