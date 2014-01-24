﻿using SFML.Graphics;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MainMenu : IGameState
{
    int current = 0;
    


    public MainMenu()
    {
        
    }

    public void Initialize()
    {
        
     
    }

    public void LoadContent(ContentManager manager)
    {
      
    }

    public EGameState Update(GameTime gameTime)
    {


        if (Input.isClicked(Keyboard.Key.S))
            current = (current + 1) % 3;

        if (Input.isClicked(Keyboard.Key.W))
            current = (current + 2) % 3;

        if(Input.isClicked(Keyboard.Key.Return))
            switch (current)
            {
                case 0: 
                    return EGameState.LevelChooser;

                case 1: 
                    return EGameState.Credits;

                case 2: 
                    return EGameState.None;
            }

        return EGameState.MainMenu;
    }

    public void Draw(GameTime gameTime, RenderWindow window)
    {
        window.Clear(Color.Red);

    }
}
