//*****************************************************************************
// Torque -- HLSL procedural shader
//*****************************************************************************

// Dependencies:
#include "shaders/common/wind.hlsl"
//------------------------------------------------------------------------------
// Autogenerated 'Light Buffer Conditioner [RGB]' Uncondition Method
//------------------------------------------------------------------------------
inline void autogenUncondition_bde4cbab(in float4 bufferSample, out float3 lightColor, out float NL_att, out float specular)
{
   lightColor = bufferSample.rgb;
   NL_att = dot(bufferSample.rgb, float3(0.3576, 0.7152, 0.1192));
   specular = bufferSample.a;
}


#include "shaders/common/lighting.hlsl"
#include "shaders/common/torque.hlsl"

// Features:
// Wind Effect
// Vert Position
// Base Texture
// Alpha Test
// Bumpmap [Deferred]
// Deferred RT Lighting
// Pixel Specular [Deferred]
// Visibility
// HDR Output
// DXTnm

struct ConnectData
{
   float2 texCoord        : TEXCOORD0;
   float4 screenspacePos  : TEXCOORD1;
   float2 vpos            : VPOS;
};


struct Fragout
{
   float4 col : COLOR0;
};


//-----------------------------------------------------------------------------
// Main
//-----------------------------------------------------------------------------
Fragout main( ConnectData IN,
              uniform sampler2D diffuseMap      : register(S0),
              uniform float     alphaTestValue  : register(C0),
              uniform sampler2D bumpMap         : register(S1),
              uniform float4    rtParams2       : register(C5),
              uniform sampler2D lightInfoBuffer : register(S2),
              uniform float4    specularColor   : register(C1),
              uniform float     specularPower   : register(C2),
              uniform float     specularStrength : register(C3),
              uniform float     visibility      : register(C4)
)
{
   Fragout OUT;

   // Wind Effect
   
   // Vert Position
   
   // Base Texture
   OUT.col = tex2D(diffuseMap, IN.texCoord);
   
   // Alpha Test
   clip( OUT.col.a - alphaTestValue );
   
   // Bumpmap [Deferred]
   float4 bumpSample = tex2D(bumpMap, IN.texCoord);
   
   // Deferred RT Lighting
   float2 uvScene = IN.screenspacePos.xy / IN.screenspacePos.w;
   uvScene = ( uvScene + 1.0 ) / 2.0;
   uvScene.y = 1.0 - uvScene.y;
   uvScene = ( uvScene * rtParams2.zw ) + rtParams2.xy;
   float3 d_lightcolor;
   float d_NL_Att;
   float d_specular;
   lightinfoUncondition(tex2D(lightInfoBuffer, uvScene), d_lightcolor, d_NL_Att, d_specular);
   OUT.col *= float4(d_lightcolor, 1.0);
   
   // Pixel Specular [Deferred]
   float specular = pow( abs(d_specular), max((specularPower / AL_ConstantSpecularPower),1.0f)) * specularStrength;
   OUT.col += float4( specularColor.rgb, 0 ) * specular * bumpSample.a;
   
   // Visibility
   fizzle( IN.vpos, visibility );
   
   // HDR Output
   OUT.col = hdrEncode( OUT.col );
   
   // DXTnm
   

   return OUT;
}
