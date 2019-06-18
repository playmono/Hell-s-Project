using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerStats
{
    //inicializar los stats, habra que ver como hacerlo para que se lean de memoria
    private static int PlayerSouls = 0;

    //Metodo para añadir almas
    //Usamos una funcion por si en un futuro tiene que calcular bonus devido a habilidades etc
    public static void AddSouls (int addedSouls)
    {
        PlayerSouls += addedSouls;
    }

    //Metodo para quitar almas
    //Usamos una funcion por si en un futuro tiene que calcular bonus devido a habilidades etc
    public static void RemoveSouls(int removedSouls)
    {
        PlayerSouls -= removedSouls;
    }

    public static int GetSouls()
    {
        return PlayerSouls;
    }
}
