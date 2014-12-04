//*****************************************************************************
// Torque -- HLSL procedural shader
//*****************************************************************************

// Dependencies:
#include "shaders/common/terrain/terrain.hlsl"
#include "shaders/common/lighting.hlsl"
//------------------------------------------------------------------------------
// Autogenerated 'Light Buffer Conditioner [RGB]' Uncondition Method
//------------------------------------------------------------------------------
inline void autogenUncondition_bde4cbab(in float4 bufferSample, out float3 lightColor, out float NL_att, out float specular)
{
   lightColor = bufferSample.rgb;
   NL_att = dot(bufferSample.rgb, float3(0.3576, 0.7152, 0.1192));
   specular = bufferSample.a;
}


#include "shaders/common/torque.hlsl"

// Features:
// Vert Position
// Terrain Base Texture
// Terrain Detail Texture 0
// Terrain Detail Texture 1
// Terrain Detail Texture 2
// Deferred RT Lighting
// HDR Output

struct ConnectData
{
   float3 texCoord        : TEXCOORD0;
   float4 detCoord0       : TEXCOORD1;
   float4 detCoord1       : TEXCOORD2;
   float4 detCoord2       : TEXCOORD3;
   float4 screenspacePos  : TEXCOORD4;
};


struct Fragout
{
   float4 col : COLOR0;
};


//-----------------------------------------------------------------------------
// Main
//-----------------------------------------------------------------------------
Fragout main( ConnectData IN,
              uniform sampler2D baseTexMap      : register(S0),
              uniform sampler2D layerTex        : register(S1),
              uniform float     layerSize       : register(C3),
              uniform float3    detailIdStrengthParallax0 : register(C0),
              uniform sampler2D detailMap0      : register(S2),
              uniform float3    detailIdStrengthParallax1 : register(C1),
              uniform sampler2D detailMap1      : register(S3),
              uniform float3    detailIdStrengthParallax2 : register(C2),
              uniform sampler2D detailMap2      : register(S4),
              uniform float4    rtParams0       : register(C4),
              uniform sampler2D lightInfoBuffer : register(S5)
)
{
   Fragout OUT;

   // Vert Position
   
   // Terrain Base Texture
   float4 baseColor = tex2D( baseTexMap, IN.texCoord.xy );
   OUT.col = baseColor;
   
   // Terrain Detail Texture 0
   float4 layerSample = round( tex2D( layerTex, IN.texCoord.xy ) * 255.0f );
   float detailBlend0 = calcBlend( detailIdStrengthParallax0.x, IN.texCoord.xy, layerSize, layerSample );
   float blendTotal = 0;
   blendTotal = max( blendTotal, detailBlend0 );
   float4 detailColor;
   if ( detailBlend0 > 0.0f )
   {
      detailColor = ( tex2D( detailMap0, IN.detCoord0.xy ) * 2.0 ) - 1.0;
      detailColor *= detailIdStrengthParallax0.y * IN.detCoord0.w;
      OUT.col = lerp( OUT.col, baseColor + detailColor, detailBlend0 );
   }
   
   // Terrain Detail Texture 1
   float detailBlend1 = calcBlend( detailIdStrengthParallax1.x, IN.texCoord.xy, layerSize, layerSample );
   blendTotal = max( blendTotal, detailBlend1 );
   if ( detailBlend1 > 0.0f )
   {
      detailColor = ( tex2D( detailMap1, IN.detCoord1.xy ) * 2.0 ) - 1.0;
      detailColor *= detailIdStrengthParallax1.y * IN.detCoord1.w;
      OUT.col = lerp( OUT.col, baseColor + detailColor, detailBlend1 );
   }
   
   // Terrain Detail Texture 2
   float detailBlend2 = calcBlend( detailIdStrengthParallax2.x, IN.texCoord.xy, layerSize, layerSample );
   blendTotal = max( blendTotal, detailBlend2 );
   if ( detailBlend2 > 0.0f )
   {
      detailColor = ( tex2D( detailMap2, IN.detCoord2.xy ) * 2.0 ) - 1.0;
      detailColor *= detailIdStrengthParallax2.y * IN.detCoord2.w;
      OUT.col = lerp( OUT.col, baseColor + detailColor, detailBlend2 );
   }
   
   // Deferred RT Lighting
   float2 uvScene = IN.screenspacePos.xy / IN.screenspacePos.w;
   uvScene = ( uvScene + 1.0 ) / 2.0;
   uvScene.y = 1.0 - uvScene.y;
   uvScene = ( uvScene * rtParams0.zw ) + rtParams0.xy;
   float3 d_lightcolor;
   float d_NL_Att;
   float d_specular;
   lightinfoUncondition(tex2D(lightInfoBuffer, uvScene), d_lightcolor, d_NL_Att, d_specular);
   OUT.col *= float4(d_lightcolor, 1.0);
   
   // HDR Output
   OUT.col = hdrEncode( OUT.col );
   

   return OUT;
}
