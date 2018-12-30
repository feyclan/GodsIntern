Shader "ghjb" {
	Properties{
		_MainTex("Texture", 2D) = "white" {}
		_Color("Color", color) = (1.000000,1.000000,1.000000,1.000000)
	}

		Category{
			Tags { "Queue" = "Geometry" }
			Lighting Off
			BindChannels {
				Bind "Color", color
				Bind "Vertex", vertex

			}

			SubShader {
			LOD 300
			Tags { "RenderType" = "Opaque" "PerformanceChecks" = "False" }
				Pass {
					SetTexture[_MainTex] {
						combine primary
					}
				}
			}
	}
}