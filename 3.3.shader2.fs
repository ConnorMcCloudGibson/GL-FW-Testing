#version 330 core
out vec4 FragColor;
in vec4 gl_FragCoord; 
uniform vec2 viewPortSize;
uniform float phasor;

in vec3 ourColor;
void main(){
vec2 coord = (gl_FragCoord.xy/viewPortSize);
float color = 0.0;   

for(float i = 0.0; i < 20; i++){
    
color +=tan(coord.y*50.0 + abs(cos(i+phasor+coord.y*1.0 + cos(coord.y*1.0 + phasor/16.0 * 1.0))))*2.0;
//color +=tan(coord.x*10.0 + sin(phasor/1.0+coord.y*20.0 + tan(coord.y*20.0 + phasor/12.0 * 2.50)))*i;
color *=sin(coord.y*1.0 + cos(phasor/20.0+coord.x*5.0 + sin(coord.x*50.0 + phasor/15.0 * 2.0)))*2.0;
//color *= /*noise1d(phasor/2000.0)/2.0* */tan(coord.x*10.0 + cos(phasor/20.0+coord.y*100.0 + tan(coord.x*50.0 + phasor/15.0 * 1.20)))*i;
color= color*sin(i);
color /= step(0.1, sin(color+phasor));
}
 FragColor = vec4(vec3(color-sin(phasor),color-cos(phasor)-0.5,color-tan(phasor)-0.2),1.0);
} 
