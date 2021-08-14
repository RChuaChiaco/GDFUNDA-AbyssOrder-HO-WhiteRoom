using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleLight : MonoBehaviour
{
    Light light;
    bool switchthis;
    float min_range;
    float max_range;
    float flicker_speed;
    // Start is called before the first frame update
    void Start()
    {
        this.light = GetComponent<Light>();
        this.switchthis = false;
        this.max_range = this.light.range;
        this.min_range = this.light.range - (this.light.range * 0.2f);
        this.flicker_speed = this.light.range * 0.0005f;
    }

    // Update is called once per frame
    void Update()
    {

        if (this.switchthis)
            this.light.range -= this.flicker_speed;
        else
            this.light.range += this.flicker_speed;
        if ((this.light.range >= this.max_range && !switchthis) || (this.light.range <= this.min_range && switchthis))
            this.switchthis = !switchthis;
    }
}
