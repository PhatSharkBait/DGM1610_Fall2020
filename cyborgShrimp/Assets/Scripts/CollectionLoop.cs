using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionLoop : MonoBehaviour
{
    public List<Collectable> pokemonList;

    private void Start()
    {
        for (var i = 0; i < pokemonList.Count; i++)
        {
            var startingPos = transform.position;
            var position = startingPos + new Vector3(i * 8, 0, 0);
            var pokemon = pokemonList[i];
            var newPokemon = new GameObject(pokemon.name);
            newPokemon.transform.position = position;
            var sprite = newPokemon.AddComponent<SpriteRenderer>();
            sprite.sprite = pokemon.art;
            sprite.color = pokemon.artColor;
            newPokemon.transform.localScale = new Vector3(10f, 10f, 10f);

        }
    }
}
