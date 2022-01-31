
#version 330 core
out vec4 FragColor;
in vec4 gl_FragCoord; 
uniform vec2 viewPortSize;
uniform float phasor;
uniform vec2 mouse_xy;
float PI= 3.14;

in vec3 ourColor;

float noise1d(float v){
    return cos(v + cos(v * 90.1415) * 100.1415)+0.5;
}

mat2 rotate(float angle){
    angle *= PI/180.0;
    return mat2(cos(angle), -sin(angle), sin(angle), cos(angle));
}

void main(){
float u_time = phasor;
vec2 coord = gl_FragCoord.xy/viewPortSize;
vec3 color = vec3(0.0);

color -= cos(coord.x /cos(u_time/10.0)*1000.0)*mouse_xy.y * tan(coord.x *cos(u_time/12.0)*10.0)*coord.y*abs(tan(u_time/20.0)*100.0)*noise1d(sin(u_time/2.0))*mouse_xy.x;
color +=(1-phasor)*tan(coord.y *cos(u_time/30.0)*10.0)+sin(coord.y *sin(u_time/102.0)*50.0)*mouse_xy.y;
color *= vec3(step(sin(u_time),color.y)+5.0)*noise1d(cos(u_time))*(2.0+10*phasor);
color *= color-vec3(rotate(abs(sin(u_time+noise1d(1-u_time))))+1.0)*noise1d(tan(u_time))*phasor;
color = (color*-2) + 5.0*noise1d(u_time);
color.x-=1;
FragColor = vec4(color, 1.0);//+vec4(coord.y*abs(sin(u_time)));
} 
