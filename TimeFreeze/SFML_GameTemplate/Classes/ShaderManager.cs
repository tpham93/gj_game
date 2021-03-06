﻿using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public enum EShader {None, Grayscale, Dark};

public static class ShaderManager
{
    private static RenderStates grayscaleRenderStates;
    private static RenderStates lightRenderStates;

    private static Shader grayscaleShader;
    private static Shader lightShader;

    
    public static void initialize()
    {
        grayscaleShader = new Shader(null, Constants.SHADERPATH + "GrayScaleShader.txt");
        grayscaleRenderStates = new RenderStates(grayscaleShader);
        grayscaleRenderStates.BlendMode = BlendMode.Alpha;

        lightShader = new Shader(null, Constants.SHADERPATH + "LightShaderFragment.txt");
        lightRenderStates = new RenderStates(lightShader);
        lightRenderStates.BlendMode = BlendMode.Add;
    }


    public static RenderStates getRenderState(EShader eShader)
    {
        switch (eShader)
        {

            case EShader.Grayscale:
                return grayscaleRenderStates;

            case EShader.Dark:
                return lightRenderStates;
    
        }

        return RenderStates.Default;
    }
}

