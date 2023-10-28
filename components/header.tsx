import Link from "next/link"
import { Route, NavLink } from "./route"
import Image from "next/image"
import logo from "@/img/logo.png"
const Header = () => {
    const NavItem:NavLink[] = [
        {label: 'Возможности', href: '/'},
        {label: 'Тарифы', href: '/tarifs'},
        {label: 'Внедрение', href: '/about'},
        {label: 'Отзывы', href: '/about'},
        {label: 'Поддержка', href: '/about'},
    ]
    return(
        <header>
            <div className="pos">
                <Image  className="logo" src={logo} alt="logo"/>
                <Route navLinks={NavItem}/>
            </div>
        </header>
    )
}
export { Header }