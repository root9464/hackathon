



import { Boxer } from "@/components/boxerreviev"
import { Metadata } from "next"
export const metadata:Metadata = {
    title: "Reviews | Next app"
} 
export default function Tarifs(){
   
    return (
        <section className="container-reviews">
            
                <Boxer/>

        </section>
    )
}
