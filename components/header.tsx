import { Route, NavLink } from "./route"
import Image from "next/image"
import logo from "@/img/logo.png"
import { Auth } from "./islandauth"
const Header = () => {
    const NavItem:NavLink[] = [
        {label: 'Возможности', href: '/'},
        {label: 'Тарифы', href: '/tarifs'},
        {label: 'Внедрение', href: '/err'},
        {label: 'Отзывы', href: '/reviews'},
        {label: 'Поддержка', href: '/about'},
    ]
    return(
        <header>
            <div className="pos">
                <Image  className="logo" src={logo} alt="logo"/>
                <Route navLinks={NavItem}/>
            </div>
            <div className="island">
                <Auth/>
            </div>    
        </header>
    )
}
export { Header }