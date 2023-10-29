"use client"
import { motion } from "framer-motion"
import image from '@/img/plug.png'
import Image from "next/image"
import { useEffect, useRef, useState } from "react"
const Slider = () => {
    const array:number[] = [...Array(15)].map(e=>~~(Math.random()*5))
    const [width, setWidth] =useState<number>(0)
    const corousel = useRef<any>()
    useEffect(() => {
        setWidth(corousel.current.scrollWidth - corousel.current.offsetWidth )  
    },[])
    
    return (
        <motion.div className="carousel" id="target1" ref={corousel} whileTap={{cursor: "grabbing"}}>
            <motion.div drag="x" dragConstraints={{right:0, left: -width}} className="inner-carousel">
                {
                array.map((e:any) => {
                    return(
                        <motion.div className="item" key={e}>
                            <Image src={image} alt='slide'></Image>
                        </motion.div>
                    )})
                }
            </motion.div>
        </motion.div>
    )
}
export { Slider }