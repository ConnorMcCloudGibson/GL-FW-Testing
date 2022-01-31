#version 330 core
out vec4 FragColor;
in vec4 gl_FragCoord; 
uniform vec2 viewPortSize;
uniform float phasor;
uniform int x;
uniform int y;
in vec3 ourColor;
float beat(int t, int a = 1024, int b = 2, int c = 32, int d = 128) { 
    return (((t*a)&128)+64)|(b*t)>>(c/8)&((1/d)*t);
}
void main(){
    ivec2 coord = gl_FragCoord.xy;
    float color = 0.0;   
    color = beat(coord.x*coord.y/255;
    FragColor = vec4(vec3(color,color,color),1.0);
}